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
using WindowsFormsi18nDemo.Page;
using static LanguagePackage.LanguageInterpret;

namespace WindowsFormsi18nDemo
{
    public partial class Form1 : Form
    {
        private PageOne PageOne;
        private PageTwo PageTwo;
        public LanguageInterpretViewManager LanguageInterpretViewManager { get; set; }
        private LanguageClassify NowLanguage => radioButton_ch.Checked ? LanguageClassify.Zh_Tw : LanguageClassify.En_Us;

        public Form1()
        {
            InitializeComponent();
            PageOne = new PageOne();
            PageTwo = new PageTwo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_PageContent.Controls.Add(PageOne);
            panel_PageContent.Controls.Add(PageTwo);
            radioButton_ch.Checked = true;

            // 多語設置處
            LanguageInterpretViewManager = new LanguageInterpretViewManager();
            OnLanguateChange += LanguageInterpretViewManager.SetAllViewText;
            var controls = new List<Control>()
            {
                button_PageOne
                , button_PageTwo
            };
            LanguageInterpretViewManager.SetLanguageControl(controls);
            LanguageInterpretViewManager.SetAllViewText();
        }

        private void button_PageOne_Click(object sender, EventArgs e)
        {
            PageOne.BringToFront();
        }

        private void button_PageTwo_Click(object sender, EventArgs e)
        {
            PageTwo.BringToFront();
        }

        private void onLanguageCheckChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (!radioButton.Checked)
                return;

            LanguageInterpret.NowLanguage = NowLanguage;
        }
    }
}
