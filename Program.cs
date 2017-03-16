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
            Application.Run(new Translatorfrm());
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
                string retext= VName + "\"" + VCHN + "\"";
                return retext;
            }
        }
    }


}
