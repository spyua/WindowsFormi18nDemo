using LanguagePackage;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsi18nDemo
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 多語設置 Path與預設語系
            LanguageInterpret.ResourcePath = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["LanguageSourcePath"];
            LanguageInterpret.NowLanguage = LanguageInterpret.LanguageClassify.Zh_Tw;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
