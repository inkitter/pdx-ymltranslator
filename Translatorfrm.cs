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
    public partial class Translatorfrm : Form
    {
        public Translatorfrm()
        {
            InitializeComponent();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            string[] stringList = Directory.GetFiles("eng\\", "*.yml");

            foreach (string str in stringList)
            {
                FilesListbox.Items.Add(Path.GetFileName(str));
            }
            FilesListbox.SelectedIndex = 0;
            //从eng目录读取文件并载入listbox，默认选择第一个文件。
        }

        private void Mainfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        List<string> listEng;
        List<string> listChn;
        List<YML> YMLText;
        string LoadedFileName = "";

        private void Savebtn_Click(object sender, EventArgs e)
        {
            int Maxnum = Math.Min(listEng.Count, listChn.Count)-1;
            for (int id = 0; id < Maxnum; id++)
            {
                WriteBack(id);
            }
            File.WriteAllLines("chn\\" + FilesListbox.Text, listChn.ToArray(), Encoding.UTF8);
            // 保存文件
        }

        private void WriteBack(int id)
        {
            listChn.Insert(id + 1, YMLText.ElementAt(id).VTranslated);
            listChn.RemoveAt(id + 2);
        }

        private void FilesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadFile();
            LoadtoDataGrid();
        }

        private string RexValName(string RegText)
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

        private string RexValue(string RegText)
        {
            Regex Reggetname = new Regex("(?<=(\\s\")).*?(?=\"$)", RegexOptions.None);
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
            Logtxtbox.Clear();
            string EngPath = "eng\\" + FilesListbox.Text;
            string ChnPath = "chn\\" + FilesListbox.Text;

            string[] str = File.ReadAllLines(EngPath);
            if (!File.Exists(ChnPath))
            {
                FileStream fs = File.Create(ChnPath);
                Byte[] info = new UTF8Encoding(true).GetBytes("l_english:");
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
            string[] LinesEng = File.ReadAllLines(EngPath);
            string[] LinesChn = File.ReadAllLines(ChnPath);

            listEng = new List<string>(LinesEng);
            listChn = new List<string>(LinesChn);
            YMLText = new List<YML>();

            for (int i=1;i<listEng.Count;i++)
            {
                YMLText.Add ( new YML {
                    VName = RexValName(listEng.ElementAt(i)),
                    VENG = RexValue(listEng.ElementAt(i)),
                    VCHN = RexValue(listChn.ElementAt(i))
                });
            }

            LoadedFileName = EngPath;
        }

        private void LoadtoDataGrid()
        {
            DataGridALL.ClearSelection();
            DataGridALL.DataSource = YMLText;
            DataGridALL.Columns[0].Width = 200;
            DataGridALL.Columns[1].Width = 300;
            DataGridALL.Columns[2].Width = 300;
            DataGridALL.Columns[3].Width = 300;
            foreach (DataGridViewRow row in DataGridALL.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }
    
        private void Showintxt()
        {
            int id = DataGridALL.CurrentRow.Index;
            txtENG.Text = YMLText.ElementAt(id).VENG;
            txtCHN.Text = YMLText.ElementAt(id).VCHN;
            Translatehttp();
        }

        private void Applybtn_Click(object sender, EventArgs e)
        {
            int id = DataGridALL.CurrentRow.Index;
            YMLText.ElementAt(id).VCHN = txtCHN.Text;
            DataGridALL.Refresh();

            
        }

        private void DataGridALL_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridALL.CurrentRow.Selected==true)
            {
                Showintxt();
            }
        }

        private async void Translatehttp()
        {
            Task<string> RetransText = new Task<string>(RequestText);
            RetransText.Start();
            Logtxtbox.Text = await RetransText;
        }

        private string RequestText()
        {
            string restring = "Nothing";

            
            string q = txtENG.Text;

            TranslationResult result = GetTranslationFromBaiduFanyi(q);
            //var bytes = new WebClient().DownloadData(address);
            //restring = Encoding.UTF8.GetString(bytes);

            return result.Trans_result[0].Dst; ;
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
            string randomNum = System.DateTime.Now.Millisecond.ToString();
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

    }
    public class Translation
    {
        public string Src { get; set; }
        public string Dst { get; set; }
    }

    public class TranslationResult
    {
        //错误码，翻译结果无法正常返回
        public string Error_code { get; set; }
        public string Error_msg { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Query { get; set; }
        //翻译正确，返回的结果
        //这里是数组的原因是百度翻译支持多个单词或多段文本的翻译，在发送的字段q中用换行符（\n）分隔
        public Translation[] Trans_result { get; set; }
    }
}
