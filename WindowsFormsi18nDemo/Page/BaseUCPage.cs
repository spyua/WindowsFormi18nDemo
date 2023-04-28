using LanguagePackage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsi18nDemo.Page
{
    public partial class BaseUCPage : UserControl
    {
        public LanguageInterpretViewManager LanguageInterpretViewManager { get; set; }

        public BaseUCPage()
        {
            //  多語設置處
            LanguageInterpretViewManager = new LanguageInterpretViewManager();
            LanguageInterpret.OnLanguateChange += LanguageInterpretViewManager.SetAllViewText;
        }
    }
}
