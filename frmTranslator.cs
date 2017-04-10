using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pdx_ymltranslator
{
    
    public partial class FrmTranslator : Form
    {
        private void Mainfrm_Load(object sender, EventArgs e)
        {
            FunRefresh();
            UserDictInitialize();
        }

        private void FunRefresh()
        {
            if (!Directory.Exists("eng\\"))
            {
                Directory.CreateDirectory("eng\\");
            }
            if (!Directory.Exists("chn\\"))
            {
                Directory.CreateDirectory("chn\\");
            }
            string[] stringList = Directory.GetFiles("eng\\", "*.yml");

            if (stringList.Length > 0)
            {
                foreach (string str in stringList)
                {
                    LstFiles.Items.Add(Path.GetFileName(str));
                }
                LstFiles.SelectedIndex = 0;
                //从eng目录读取文件并载入listbox，默认选择第一个文件。
            }
            else
            {
                LstFiles.Items.Add("No YML File in directory");
                LstFiles.Enabled = false;
                BtnApply.Enabled = false;
                BtnAPItochnBox.Enabled = false;
            }
        }

        List<string> listEng;
        List<string> listChn;
        List<YML> YMLText;
        Dictionary<string, string> UserDict = new Dictionary<string, string>();
        const string UserDictCSV = "ymldict.csv";

        private void UserDictInitialize()
        {
            if (!File.Exists(UserDictCSV))
            {
                return;
            }
            var reader = new StreamReader(File.OpenRead(UserDictCSV),Encoding.UTF8, true);
            try
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (!String.IsNullOrEmpty(values[0]) && !String.IsNullOrEmpty(values[1]))
                    {
                        UserDict.Add(values[0].ToLower(), values[1]);
                    }
                }
            }
            catch { }
            reader.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FuncSave();
        }

        private void FuncSave()
        {
            List<string> lstWriteback = new List<string>();
            
            for (int id = 0; id < YMLText.Count - 1; id++)
            {
                lstWriteback.Add(YMLText.ElementAt(id).TranslatedLine);
            }
            File.WriteAllLines("chn\\" + LstFiles.Text, lstWriteback.ToArray(), Encoding.UTF8);
            BtnSave.Enabled = false;
            // 保存文件
        }

        private void LstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstFiles.Enabled == true)
            {
                ReadFile();
                LoadtoDataGrid();
            }
        }

        private void ReadFile()
        {
            string EngPath = "eng\\" + LstFiles.Text;
            string ChnPath = "chn\\" + LstFiles.Text;

            if (!File.Exists(ChnPath))
            {
                FileStream fs = File.Create(ChnPath);
                Byte[] info = new UTF8Encoding(true).GetBytes("l_english:");
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
            // 检测chn文件夹内文件是否存在，不存在则建立。

            listEng = new List<string>(File.ReadAllLines(EngPath));
            listChn = new List<string>(File.ReadAllLines(ChnPath));

            YMLText=YMLTools.BuildYMLList(listEng, listChn);
        }

        private void LoadtoDataGrid()
        {
            DfData.ClearSelection();
            DfData.DataSource = YMLText;
            // 将对象映射到datagrid里。

            DfData.Columns[0].Width = 200;
            DfData.Columns[1].Width = 300;
            DfData.Columns[2].Width = 300;
            DfData.Columns[3].Width = 300;
            DfData.Columns[4].Width = 300;
            //DfData.Columns[2].HeaderText = "Original Line";
            //DfData.Columns[0].HeaderText = "FROM";
            //DfData.Columns[1].HeaderText = "TransTo";
            //DfData.Columns[3].HeaderText = "Save Preview";
            //DfData.Columns[4].HeaderText = "Variable Name";
            // 调整datagrid样式

            foreach (DataGridViewRow row in DfData.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
                if (row.Cells[0].Value.ToString()==row.Cells[1].Value.ToString() && row.Cells[1].Value.ToString()!="")
                {
                    row.Cells[1].Style.BackColor = Color.LightCyan;
                }
            }
            // 寻找原文与译文内容一致的，标记颜色，醒目便于确认需要翻译的部分。
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            TxtCHN.Text = YMLTools.RemoveReturnMark(TxtCHN.Text);
            YMLText.ElementAt(DfData.CurrentRow.Index).ApplyLine( TxtCHN.Text);
            DfData.Refresh();
            //将文本框内容移除换行符，放回变量，并刷新datagrid。
            BtnSave.Enabled = true;
            //做过修改，保存按钮可以使用了。
        }

        private void DfData_SelectionChanged(object sender, EventArgs e)
        {
            if (DfData.CurrentRow.Selected == true)
            {
                Showintxt(DfData.CurrentRow.Index);
            }
        }

        private void Showintxt(int id)
        {
            if (UserDict.Count>0)
            {
                TxtENG.Text = YMLTools.ReplaceWithUserDict(YMLText.ElementAt(id).VENG, UserDict);
            }
            else
            {
                TxtENG.Text = YMLText.ElementAt(id).VENG;
            }

            TxtCHN.Text = YMLText.ElementAt(id).VCHN;

            if (!YMLText.ElementAt(id).IsEditable())
            {
                BtnApply.Enabled = false;
            }
            else
            {
                BtnApply.Enabled = true;
            }
            GetAPITranslation();
        }

        private async void GetAPITranslation()
        {
            TxtLog.Clear();
            BtnAPItochnBox.Enabled = false;
            Task<string> GetTranslationTask = new Task<string>(FuncAsyncGetTranslation);
            try
            {
                GetTranslationTask.Start();
                TxtLog.Text = await GetTranslationTask;
                GetTranslationTask.Dispose();
            }
            catch
            {
                TxtLog.Text = "Nothing";
                GetTranslationTask.Dispose();
            }
            BtnAPItochnBox.Enabled = true;

            string FuncAsyncGetTranslation()
            {
                return YMLTools.GetTranslatedTextFromAPI(YMLTools.RemoveReturnMark(TxtENG.Text));
            }
        }
          

        public FrmTranslator()
        {
            InitializeComponent();
        }
        private void Mainfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void TxtCHN_Enter(object sender, EventArgs e)
        {
            TxtCHN.SelectAll();
        }
        private void TxtCHN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
            {
                TxtCHN.SelectAll();
            }
        }

        private void TxtENG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
            {
                TxtENG.SelectAll();
            }
            if (e.KeyCode == Keys.Right && e.Modifiers == Keys.Control)
            {
                GetAPITranslation();
            }
        }

        private void Logtxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
            {
                TxtLog.SelectAll();
            }
        }

        private void TxtCHN_DoubleClick(object sender, EventArgs e)
        {
            TxtCHN.SelectAll();
        }

        private void Logtxtbox_DoubleClick(object sender, EventArgs e)
        {
            TxtLog.SelectAll();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chn\\" + LstFiles.Text);
        }

        private void BtnOpenFileOriginal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("eng\\" + LstFiles.Text);
        }
        private void TxtCHN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void DataGridALL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && e.Modifiers == Keys.Control)
            {
                e.Handled = true;
            }
        }
        private void BtnAPItochnBox_Click(object sender, EventArgs e)
        {
            TxtCHN.Text = TxtLog.Text;
        }

        private void Translatorfrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control)
            {
                BtnApply_Click(sender, e);
            }
            if (e.KeyCode == Keys.Up && e.Modifiers == Keys.Control)
            {
                BtnAPItochnBox_Click(sender, e);
            }
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                BtnSave_Click(sender, e);
            }
        }

        private void BtnOpenBrowser_Click(object sender, EventArgs e)
        {
            if (RadioBaidu.Checked)
            {
                YMLTools.TranslationBrowser(TxtENG.Text, "Baidu");
            }
            if (RadioGoogle.Checked)
            {
                YMLTools.TranslationBrowser(TxtENG.Text, "Google");
            }
        }
        private void FuncInsertSign(string SignToInsert)
        {
            if (TxtCHN.SelectedText == "")
            {
                TxtCHN.SelectedText = "§"+ SignToInsert;
            }
            else
            {
                TxtCHN.SelectedText = "§"+ SignToInsert + TxtCHN.SelectedText + "§!";
            }
        }

        private void LabColorR_Click(object sender, EventArgs e)
        {
            FuncInsertSign("R");
        }

        private void LabColorG_Click(object sender, EventArgs e)
        {
            FuncInsertSign("G");
        }

        private void LabColorB_Click(object sender, EventArgs e)
        {
            FuncInsertSign("B");
        }

        private void LabColorH_Click(object sender, EventArgs e)
        {
            FuncInsertSign("H");
        }

        private void LabColorL_Click(object sender, EventArgs e)
        {
            FuncInsertSign("L");
        }

        private void LabColorS_Click(object sender, EventArgs e)
        {
            FuncInsertSign("S");
        }

        private void LabColorM_Click(object sender, EventArgs e)
        {
            FuncInsertSign("M");
        }

        private void LabColorGx_Click(object sender, EventArgs e)
        {
            FuncInsertSign("g");
        }

        private void LabColorW_Click(object sender, EventArgs e)
        {
            FuncInsertSign("W");
        }

        private void LabColorY_Click(object sender, EventArgs e)
        {
            FuncInsertSign("Y");
        }

        private void LabColorE_Click(object sender, EventArgs e)
        {
            FuncInsertSign("E");
        }

        private void LabColorEnd_Click(object sender, EventArgs e)
        {
            TxtCHN.SelectedText = "§!";
        }
    }
}
