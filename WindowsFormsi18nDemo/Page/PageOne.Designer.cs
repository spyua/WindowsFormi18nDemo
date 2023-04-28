namespace WindowsFormsi18nDemo.Page
{
    partial class PageOne
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Message = new System.Windows.Forms.GroupBox();
            this.button_Dialog = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.groupBox_Message.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Message
            // 
            this.groupBox_Message.Controls.Add(this.button_Dialog);
            this.groupBox_Message.Controls.Add(this.textBox1);
            this.groupBox_Message.Controls.Add(this.label_Info);
            this.groupBox_Message.Location = new System.Drawing.Point(8, 8);
            this.groupBox_Message.Name = "groupBox_Message";
            this.groupBox_Message.Size = new System.Drawing.Size(423, 269);
            this.groupBox_Message.TabIndex = 1;
            this.groupBox_Message.TabStop = false;
            this.groupBox_Message.Text = "Page One Content";
            // 
            // button_Dialog
            // 
            this.button_Dialog.Location = new System.Drawing.Point(24, 81);
            this.button_Dialog.Name = "button_Dialog";
            this.button_Dialog.Size = new System.Drawing.Size(75, 23);
            this.button_Dialog.TabIndex = 2;
            this.button_Dialog.Text = "Dialog";
            this.button_Dialog.UseVisualStyleBackColor = true;
            this.button_Dialog.Click += new System.EventHandler(this.button_Dialog_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(22, 40);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(64, 12);
            this.label_Info.TabIndex = 0;
            this.label_Info.Text = "Information:";
            // 
            // PageOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Message);
            this.Name = "PageOne";
            this.Size = new System.Drawing.Size(443, 286);
            this.Load += new System.EventHandler(this.PageOne_Load);
            this.groupBox_Message.ResumeLayout(false);
            this.groupBox_Message.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Message;
        private System.Windows.Forms.Button button_Dialog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Info;
    }
}
