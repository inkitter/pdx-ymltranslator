using System;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Web.Script.Serialization;
using System.Collections.Generic;

namespace pdx_ymltranslator
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmTranslator());
        }
    }

    class YML
    {
        public string VENG { get; set; }
        public string VCHN { get; set; }
        public string AllENG { get; set; }
        public string VTranslated {
            get
            {
                string retext="";
                if (VName != "")
                {
                    retext = VName + "\"" + VCHN + "\"";
                }
                else
                {
                    retext = AllENG;
                }
                return retext;
            }
        }
        public string VName { get; set; }
    }

    public class Translation
    {
        public string Src { get; set; }
        public string Dst { get; set; }
    }

    public class TranslationResultVIP
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

    public class TranslationResult
    {
        //public string From { get; set; }
        //public string To { get; set; }
        public Translation[] Data { get; set; }
    }

    public static class YMLTools
    {
        private static TranslationResult GetTranslationFromBaiduFanyi(string q)
        {
            WebClient wc = new WebClient();
            JavaScriptSerializer jss = new JavaScriptSerializer();
            TranslationResult result = jss.Deserialize<TranslationResult>(wc.DownloadString("http://fanyi.baidu.com/transapi?from=en&to=zh&query=" + WebUtility.UrlEncode(q)));
            return result;
            //解析json
        }

        public static string GetTranslatedTextFromAPI(string TexttoTranslate)
        {
            if (TexttoTranslate != "")
            {
                TranslationResult result = GetTranslationFromBaiduFanyi(TexttoTranslate);
                return result.Data[0].Dst;
            }
            return "Nothing";
        }
        // 用于从baidu 翻译API获取翻译。

        public static string FuncRegex(string RegText, string RegexRule)
        {
            Regex Reggetname = new Regex(RegexRule, RegexOptions.None);
            StringBuilder returnString = new StringBuilder();
            var matches = Reggetname.Matches(RegText);

            foreach (var item in matches)
            {
                returnString.Append(item.ToString());
            }
            return returnString.ToString();
        }
        // 用于截取

        public static void TranslationBrowser(string TextToTranslate,string APIEngine)
        {
            StringBuilder StrOpeninBrowser = new StringBuilder();
            switch (APIEngine)
            {
                case "Google":
                    StrOpeninBrowser.Append("http://translate.google.com/?#auto/zh-CN/");
                    break;
                case "Baidu":
                    StrOpeninBrowser.Append("http://fanyi.baidu.com/?#en/zh/");         
                    break;
                default:
                    StrOpeninBrowser.Append("http://fanyi.baidu.com/?#en/zh/");
                    break;
            }
            StrOpeninBrowser.Append(TextToTranslate);
            System.Diagnostics.Process.Start(StrOpeninBrowser.ToString());
        }
        // 用于默认浏览器打开翻译网页

        public static string RemoveReturnMark(string input)
        {
            StringBuilder RemoveReturnText = new StringBuilder();
            RemoveReturnText.Append(input);
            RemoveReturnText.Replace("\r", "");
            RemoveReturnText.Replace("\n", "");
            return RemoveReturnText.ToString();
        }
        // 用于移除换行符。

        public static string ReplaceWithUserDict(string input, Dictionary<string, string> UserDict)
        {
            StringBuilder ConverText = new StringBuilder();
            ConverText.Append(input.ToLower());
            foreach (KeyValuePair<string, string> kvp in UserDict)
            {
                ConverText.Replace(kvp.Key, kvp.Value);
            }
            return ConverText.ToString();
        }
    }

}
