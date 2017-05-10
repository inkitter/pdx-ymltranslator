using System;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.IO;

namespace pdx_ymltranslator
{
    static class StaticVars
    {
        public const string UserDictCSV = "ymldict.csv";
        public const string DirOldBase = "old\\";
        public const string DIRCN = "chn\\";
        public const string DIRCNen = "chn\\english\\";
        public const string DIRCNcn = "chn\\simp_chinese\\";
        public const string DIREN = "eng\\";
    }
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

    public class YML
    {
        private string lineeng;
        private string linechn;
        private string veng;
        private string vchn;
        private string variablename;
        private string variablenamewithoutnum;
        private string oldeng;
        private int lineindex = 0;
        public YML()
        {
            lineeng = "";
            linechn = "";
            veng = "";
            vchn = "";
            variablename = "";
            variablenamewithoutnum = "";
            oldeng = "";
        }
        public YML(string LineTo):this()
        {
            LineCHN = LineTo;
            LineENG = "";
            variablename = YMLTools.RegexGetName(LineTo);
            variablenamewithoutnum = YMLTools.RegexGetNameOnly(variablename);
            vchn = YMLTools.RegexGetValue(LineTo);
            if (HasError()) { FixError(); }
            oldeng = "";
        }
        public YML(string LineFrom, Dictionary<string, string> DictForTo):this()
        {
            LineENG = LineFrom;
            variablename = YMLTools.RegexGetName(LineFrom);
            variablenamewithoutnum = YMLTools.RegexGetNameOnly(variablename);
            veng = YMLTools.RegexGetValue(LineFrom);

            if (VariableNameWithoutNum != "" && DictForTo.TryGetValue(VariableNameWithoutNum, out string outvalue) && outvalue != "")
            {
                LineCHN = outvalue;
                //vchn = YMLTools.RegexGetValue(outvalue);
            }
            else
            {
                LineCHN = LineFrom;
                //vchn = YMLTools.RegexGetValue(LineFrom);
            }

            if (HasError()) { FixError(); }
            oldeng = "";
        }


        public void LoadWithOldDict(Dictionary<string, string> OldDict)
        {
            if (VariableNameWithoutNum != "" && OldDict.TryGetValue(VariableNameWithoutNum, out string outvalue) && outvalue != "")
            {
                oldeng = YMLTools.RegexGetValue(outvalue);
            }
            else { oldeng = ""; }
        }
        public void LineIndexInitialize(int inputLineIndex)
        {
            lineindex = inputLineIndex;
        }

        public string VariableNameWithoutNum
        {
            get
            {
                return variablenamewithoutnum;
            }
        }
        public string VENG
        {
            get
            {
                if (IsComment()) { return lineeng; }
                return veng;
            }
        }

        public string VCHN
        {
            get
            {
                return vchn;
            }
        }
        public string OldENG
        {
            get { return oldeng; }
        }

        public string TranslatedLine
        {
            get
            {
                if (IsLineWithComment()) { return LineCHN.Replace(TestComment(), variablename + "\"" + vchn + "\""); }
                if (variablename != "") { return variablename + "\"" + vchn + "\""; }
                else { return linechn; }
            }
        }
        
        private string LineENG
        {
            get { return lineeng; }
            set
            {
                veng = YMLTools.RegexGetValue(value);
                variablename = YMLTools.RegexGetName(value);
                lineeng = value;
            }
        }

        private string LineCHN
        {
            get { return linechn; }
            set
            {
                vchn = YMLTools.RegexGetValue(value);
                variablename = YMLTools.RegexGetName(value);
                linechn = value;
            }
        }

       

        private string VariableName
        {
            get { return variablename; }
            set
            {
                variablenamewithoutnum = YMLTools.RegexGetNameOnly(value);
                variablename = value;
            }
        }

        public void ApplyLine(string ApplyText)
        {
            if (IsComment()) { linechn = ApplyText; }
            else { vchn = ApplyText; }
            vchn = ApplyText;
        }
        
        private string HasErrorText
        {
            get
            {
                if (HasError()) { return "Error"; }
                else { return ""; }
            }
        }

        public void FixError()
        {
            LineCHN = VariableName + "\"" + LineCHN.Replace(VariableName, "") + "\"";
        }

        private bool IsComment()
        {
            try { if (LineCHN.Replace(" ", "").Substring(0, 1) == "#") { return true; } }
            catch { }
            return false;
        }
        private bool IsSpaceLine()
        {
            if (LineCHN.Replace(" ", "") == "") { return true; }
            return false;
        }
        public bool IsEditable()
        {
            if (IsSpaceLine()) { return false; }
            if (LineCHN.Replace(" ", "") == "l_english:") { return false; }
            if (IsComment()) { return false; }
            return true;
        }
        private string TestComment()
        {
            return YMLTools.RegexGetName(LineCHN) + "\"" + YMLTools.RegexGetValue(LineCHN) + "\"";
        }
        private bool IsLineWithComment()
        {
            if (LineCHN.Replace(TestComment(),"").Replace(" ","")!="")
            { return true; }
            return false;
        }
        private bool HasError()
        {
            if (variablename != "" && vchn == "" && LineCHN != LineENG)
            { return true; }
            return false;
        }
        public bool SameInToAndFrom()
        {
            if (IsEditable()&&veng == vchn && veng!="") { return true; }
            return false;
        }
        public bool IsAllQoute()
        {
            return IsAllQoute(veng);
        }
        public bool IsAllQoute(string text)
        {
            if (text != "")
            {
                text = YMLTools.RemoveSpace(text);
                string first = text.Substring(0, 1);
                string end = text.Substring(text.Length - 1);
                if (first == "$" && end == "$") { return true; }
                if (first == "[" && end == "]") { return true; }

                //if (first == "§" && text.Substring(text.Length - 2) == "§!")
                //{
                //    if (IsAllQoute(YMLTools.RegexRemoveColorSign(text))) { return true; }
                //}
            }
            return false;
        }
        public bool OldNewisDifferent()
        {
            if (YMLTools.RemoveSpace(oldeng) == YMLTools.RemoveSpace(veng)) { return false;  }
            return true;
        }
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

    public class Translation
    {
        public string Src { get; set; }
        public string Dst { get; set; }
    }

    public class FileExistInfo
    {
        public bool IsExist { get; set; }
        public string FileName { get; set; }
    }

    public class LoadedFileInfo
    {
        public bool IsTranslationExist { get; set; }
        public string FileName { get; set; }
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

        public static string RegexGetWith(string RegText, string RegexRule)
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
        public static string RegexGetName(string RegText)
        {
            return RegexGetWith(RegText, "(^.*?):.*?(?=\")");
        }
        public static string RegexGetValue(string RegText)
        {
            return RegexGetWith(RegText, "(?<=(\\s\")).+(?=\")");
        }
        public static string RegexGetNameOnly(string RegText)
        {
            RegText = RegText.Replace(" ", "");
            return RegexGetWith(RegText, "^.*(?=:)");
        }
        public static string RegexRemoveColorSign(string RegText)
        {
            return RegexGetWith(RegText, "(?<=(§.)).+(?=(§!))");
        }
        private static string RegexStringWordBoundry(string input)
        {
            return @"(\W|^)" + input + @"(\W|$)";
        }
        public static bool RegexContainsWord(string input, string WordToMatch)
        {
            if (Regex.IsMatch(input, RegexStringWordBoundry(WordToMatch), RegexOptions.IgnoreCase)) { return true; }
            return false;
        }
        // 用于截取

        public static void OpenWithBrowser(string TextToTranslate,string APIEngine)
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
                case "Help":
                    StrOpeninBrowser.Append("https://github.com/inkitter/pdx-ymltranslator");
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

        public static string RemoveSpace(string input)
        {
            return input.Replace(" ", "");
        }

        public static string ReplaceWithUserDict(string input, Dictionary<string, string> dict)
        {
            foreach (KeyValuePair<string, string> kvp in dict)
            {
                Regex rgx = new Regex(RegexStringWordBoundry(kvp.Key), RegexOptions.IgnoreCase);
                input = rgx.Replace(input, " "+kvp.Key + "<" + kvp.Value + "> ");
            }
            return input;
        }

        public static List<YML> BuildYMLList(List<string> listEng,List<string> listChn)
        {
            Dictionary<string, string> dictChn = BuildDictionary(listChn);

            List<YML> returnYMLList = new List<YML>();
            foreach (string lineEng in listEng)
            {
                returnYMLList.Add(new YML(lineEng,dictChn));
            }
            foreach (YML lineYML in returnYMLList)
            {
                if (dictChn.ContainsKey(lineYML.VariableNameWithoutNum))
                {
                    dictChn.Remove(lineYML.VariableNameWithoutNum);
                }
            }
            List<string> dictLeft = new List<string>(dictChn.Values);
            foreach (string lineLeft in dictLeft)
            {
                returnYMLList.Add(new YML(lineLeft));
            }
            return returnYMLList;
        }

        public static Dictionary<string, string> BuildDictionary(List<string> list)
        {
            Dictionary<string, string> returnDict = new Dictionary<string, string>();
            foreach (string line in list)
            {
                string vn = RegexGetNameOnly(RegexGetName(line));
                if (!returnDict.ContainsKey(vn))
                {
                    returnDict.Add(vn, line);
                }
            }
            return returnDict;
        }

        public static string ToSimplifiedChinese(string s)
        {
            return Strings.StrConv(s, VbStrConv.SimplifiedChinese, 0);
        }
        public static string ToTraditionalChinese(string s)
        {
            return Strings.StrConv(s, VbStrConv.TraditionalChinese, 0);
        }

        public static FileExistInfo IsFileExistInfo(string filename)
        {
            FileExistInfo finfo = new FileExistInfo() { FileName = filename, IsExist = false };

            if (File.Exists(finfo.FileName))
            {
                finfo.IsExist = true;
                return finfo;
            }

            finfo.FileName = finfo.FileName.Replace("english.yml", "l_simp_chinese.yml");
            if (File.Exists(finfo.FileName))
            {
                finfo.IsExist = true;
                return finfo;
            }

            finfo.FileName = finfo.FileName.Replace("l_simp_chinese.yml", "l_english.yml");
            if (File.Exists(finfo.FileName))
            {
                finfo.IsExist = true;
                return finfo;
            }
            finfo.FileName = filename;
            return finfo;
        }

        public static List<YML> ReadFile(string filename)
        {
            string EngPath = StaticVars.DIREN + filename;
            string ChnPath = StaticVars.DIRCNen + filename;

            FileExistInfo finfo = IsFileExistInfo(ChnPath);
            if (!finfo.IsExist)
            {
                FileStream fs = File.Create(ChnPath);
                Byte[] info = new UTF8Encoding(true).GetBytes("l_english:");
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
            // 检测chn文件夹内文件是否存在，不存在则建立。

            List<string> listEng = new List<string>(File.ReadAllLines(EngPath));
            if (EngPath.Contains("simp_chinese.yml")) { ChnPath = ChnPath.Replace("simp_chinese.yml", "english.yml"); }
            List<string> listChn = new List<string>(File.ReadAllLines(ChnPath));

            return BuildYMLList(listEng, listChn);
        }
    }

}
