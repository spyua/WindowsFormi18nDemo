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
    public partial class PageOne : BaseUCPage
    {
        public PageOne()
        {
            InitializeComponent();
        }

        private void PageOne_Load(object sender, EventArgs e)
        {
            // 多語設置處
            var controls = new List<Control>()
            {
                groupBox_Message
                , label_Info
                , button_Dialog
            };
            LanguageInterpretViewManager.SetLanguageControl(controls);
            LanguageInterpretViewManager.SetAllViewText();
        }

        private void button_Dialog_Click(object sender, EventArgs e)
        {
            var msg = LanguageInterpret.InterpretMessage("@燈箱點擊");
            MessageBox.Show(msg + textBox1.Text);
        }
    }
}
