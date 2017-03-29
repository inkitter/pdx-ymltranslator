using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

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
            Application.Run(new frmTranslator());
        }
    }

    class YML
    {
        public string VName { get; set; }
        public string VENG { get; set; }
        public string VCHN { get; set; }
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
                    retext = "";
                }
                return retext;
            }
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
