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
        string StrRegexVarName = "(^.*?):.*?(?=\")";
        string StrRegexVarValue = "(?<=(\\s\")).+(?=\")";

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FuncSave();
        }

        private void FuncSave()
        {
            int Maxnum = Math.Min(listEng.Count, listChn.Count) - 1;
            for (int id = 0; id < Maxnum; id++)
            {
                WriteBack(id);
            }
            File.WriteAllLines("chn\\" + LstFiles.Text, listChn.ToArray(), Encoding.UTF8);
            BtnSave.Enabled = false;
            // 保存文件
        }

        private void WriteBack(int id)
        {
            listChn.Insert(id, YMLText.ElementAt(id).VTranslated);
            listChn.RemoveAt(id + 1);
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
            TxtLog.Clear();
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
            YMLText = new List<YML>();

            for (int i = 0; i < listEng.Count; i++)
            {
                if (i < listChn.Count)
                {
                    YMLText.Add(new YML
                    {
                        AllENG = listEng.ElementAt(i),
                        VName = YMLTools.FuncRegex(listEng.ElementAt(i), StrRegexVarName),
                        VENG = YMLTools.FuncRegex(listEng.ElementAt(i), StrRegexVarValue),
                        VCHN = YMLTools.FuncRegex(listChn.ElementAt(i), StrRegexVarValue)
                    });
                }
                else
                {
                    YMLText.Add(new YML
                    {
                        VName = YMLTools.FuncRegex(listEng.ElementAt(i),StrRegexVarName),
                        VENG = YMLTools.FuncRegex(listEng.ElementAt(i), StrRegexVarValue),
                        VCHN = "Please use YML merger to merge."
                    });
                }
            }
        }

        private void LoadtoDataGrid()
        {
            DfData.ClearSelection();
            DfData.DataSource = YMLText;
            DfData.Columns[0].Width = 300;
            DfData.Columns[1].Width = 300;
            DfData.Columns[2].Width = 300;
            DfData.Columns[3].Width = 300;
            DfData.Columns[4].Width = 300;
            DfData.Columns[2].HeaderText = "Original Line";
            DfData.Columns[0].HeaderText = "FROM";
            DfData.Columns[1].HeaderText = "TransTo";
            DfData.Columns[3].HeaderText = "Save Preview";
            DfData.Columns[4].HeaderText = "Variable Name";
            foreach (DataGridViewRow row in DfData.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
                if (row.Cells[0].Value.ToString()==row.Cells[1].Value.ToString() && row.Cells[1].Value.ToString()!="")
                {
                    row.Cells[1].Style.BackColor = Color.LightCyan;
                }
            }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            TxtCHN.Text = TxtCHN.Text.Replace("\n", "");
            TxtCHN.Text = TxtCHN.Text.Replace("\r", "");
            YMLText.ElementAt(DfData.CurrentRow.Index).VCHN = TxtCHN.Text;
            DfData.Refresh();
            //将文本框内容放入对象，并刷新datagrid。
            BtnSave.Enabled = true;
            //做过修改，保存按钮可以使用了。
        }

        private void DfData_SelectionChanged(object sender, EventArgs e)
        {
            if (DfData.CurrentRow.Selected == true)
            {
                Showintxt();
            }
        }

        private void Showintxt()
        {
            int id = DfData.CurrentRow.Index;
            TxtENG.Text = YMLText.ElementAt(id).VENG;
            TxtCHN.Text = YMLText.ElementAt(id).VCHN;
            if (YMLText.ElementAt(id).VName=="" || YMLText.ElementAt(id).VName == "l_english:")
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
        }
        private string FuncAsyncGetTranslation()
        {
            StringBuilder AskAPIText = new StringBuilder();
            AskAPIText.Append(TxtENG.Text);
            AskAPIText.Replace("\r", "");
            AskAPIText.Replace("\n", "");
            AskAPIText.Replace("\\n", "\\n ");
            
            return YMLTools.GetTranslatedTextFromAPI(AskAPIText.ToString());
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
    }
}
