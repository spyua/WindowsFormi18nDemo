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
    public partial class PageTwo : BaseUCPage
    {
        public PageTwo()
        {
            InitializeComponent();
        }

        private void PageTwo_Load(object sender, EventArgs e)
        {
            // 設置處
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

        private void groupBox_Message_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Info_Click(object sender, EventArgs e)
        {

        }

     
    }
}
