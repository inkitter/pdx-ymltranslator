using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Web.Script.Serialization;
using System.Collections;

namespace pdx_ymltranslator
{
    public partial class FrmTranslator : Form
    {
        public FrmTranslator()
        {
            InitializeComponent();
        }

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

        private void Mainfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        List<string> listEng;
        List<string> listChn;
        List<YML> YMLText;
        string LoadedFileName = "";

        private void BtnSave_Click(object sender, EventArgs e)
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
            listChn.Insert(id + 1, YMLText.ElementAt(id).VTranslated);
            listChn.RemoveAt(id + 2);
        }

        private void LstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstFiles.Enabled == true)
            {
                ReadFile();
                LoadtoDataGrid();
            }
        }

        private static string RexValName(string RegText)
        {
            Regex Reggetname = new Regex("(^.*?):.*?(?=\")", RegexOptions.None);
            string retext = "";
            var matches = Reggetname.Matches(RegText);

            foreach (var item in matches)
            {
                retext += item.ToString();
            }
            return retext;
        }
        // 根据正则表达式读取":"前的变量名。

        private static string RexValue(string RegText)
        {
            Regex Reggetname = new Regex("(?<=(\\s\")).+(?=\")", RegexOptions.None);
            //  "\"(.*?)*\"$"
            string retext = "";
            var matches = Reggetname.Matches(RegText);

            foreach (var item in matches)
            {
                retext += item.ToString();
            }
            return retext;
        }

        // 保存最终文本信息的全局变量，方便传递

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
                        VName = RexValName(listEng.ElementAt(i)),
                        VENG = RexValue(listEng.ElementAt(i)),
                        VCHN = RexValue(listChn.ElementAt(i))
                    });
                }
                else
                {
                    YMLText.Add(new YML
                    {
                        VName = RexValName(listEng.ElementAt(i)),
                        VENG = RexValue(listEng.ElementAt(i)),
                        VCHN = "Please use YML merger to merge."
                    });
                }
            }
            LoadedFileName = EngPath;
        }

        private void LoadtoDataGrid()
        {
            DfData.ClearSelection();
            DfData.DataSource = YMLText;
            DfData.Columns[0].Width = 200;
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

        private void Applybtn_Click(object sender, EventArgs e)
        {
            int id = DfData.CurrentRow.Index;
            YMLText.ElementAt(id).VCHN = TxtCHN.Text;
            DfData.Refresh();
            BtnSave.Enabled = true;

        }

        private void DataGridALL_SelectionChanged(object sender, EventArgs e)
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
            Translatehttp();
        }

        private async void Translatehttp()
        {
            BtnAPItochnBox.Enabled = false;
            Task<string> RetransText = new Task<string>(RequestText);
            RetransText.Start();
            TxtLog.Text = await RetransText;
            BtnAPItochnBox.Enabled = true;
        }

        private string RequestText()
        {
            string restring = "Nothing";

            if (TxtENG.Text != "")
            {
                string q = TxtENG.Text;

                TranslationResult result = GetTranslationFromBaiduFanyi(q);
                restring = result.Trans_result[0].Dst;
            }

            return restring;
        }

        private static TranslationResult GetTranslationFromBaiduFanyi(string q)
        {
            //可以直接到百度翻译API的官网申请
            //此处的都是子丰随便写的，所以肯定是不能用的
            //一定要去申请，不然程序的翻译功能不能使用
            string appID = "20170316000042351";
            string password = "6fiPwb6_lv2tuUS_wmCP";

            string jsonResult = String.Empty;
            //随机数
            string randomNum = DateTime.Now.Millisecond.ToString();
            //md5加密
            string md5Sign = GetMD5WithString(appID + q + randomNum + password);
            //url
            string url = String.Format("http://api.fanyi.baidu.com/api/trans/vip/translate?q={0}&from={1}&to={2}&appid={3}&salt={4}&sign={5}",
                WebUtility.UrlEncode(q),
                "en",
                "zh",
                appID,
                randomNum,
                md5Sign
                );
            WebClient wc = new WebClient();
            try
            {
                jsonResult = wc.DownloadString(url);
            }
            catch
            {
                jsonResult = string.Empty;
            }
            //解析json
            JavaScriptSerializer jss = new JavaScriptSerializer();
            TranslationResult result = jss.Deserialize<TranslationResult>(jsonResult);
            return result;
        }

        private static string GetMD5WithString(string input)
        {
            if (input == null)
            {
                return null;
            }
            MD5 md5Hash = MD5.Create();
            //将输入字符串转换为字节数组并计算哈希数据  
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            //创建一个 Stringbuilder 来收集字节并创建字符串  
            StringBuilder sBuilder = new StringBuilder();
            //循环遍历哈希数据的每一个字节并格式化为十六进制字符串  
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            //返回十六进制字符串  
            return sBuilder.ToString();
        }

        private void BtnAPItochnBox_Click(object sender, EventArgs e)
        {
            TxtCHN.Text = TxtLog.Text;
        }

        private void Translatorfrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control)
            {
                Applybtn_Click(sender, e);
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
        }

        private void Logtxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
            {
                TxtLog.SelectAll();
            }
        }

        private void TxtENG_DoubleClick(object sender, EventArgs e)
        {
            TxtENG.SelectAll();
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
    }
}
