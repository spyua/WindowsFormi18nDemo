namespace WindowsFormsi18nDemo
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_PageTwo = new System.Windows.Forms.Button();
            this.button_PageOne = new System.Windows.Forms.Button();
            this.panel_PageContent = new System.Windows.Forms.Panel();
            this.radioButton_en = new System.Windows.Forms.RadioButton();
            this.radioButton_ch = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button_PageTwo
            // 
            this.button_PageTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_PageTwo.Location = new System.Drawing.Point(115, 21);
            this.button_PageTwo.Name = "button_PageTwo";
            this.button_PageTwo.Size = new System.Drawing.Size(75, 23);
            this.button_PageTwo.TabIndex = 12;
            this.button_PageTwo.Text = "Page Two";
            this.button_PageTwo.UseVisualStyleBackColor = true;
            this.button_PageTwo.Click += new System.EventHandler(this.button_PageTwo_Click);
            // 
            // button_PageOne
            // 
            this.button_PageOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_PageOne.Location = new System.Drawing.Point(34, 21);
            this.button_PageOne.Name = "button_PageOne";
            this.button_PageOne.Size = new System.Drawing.Size(75, 23);
            this.button_PageOne.TabIndex = 11;
            this.button_PageOne.Text = "Page One";
            this.button_PageOne.UseVisualStyleBackColor = true;
            this.button_PageOne.Click += new System.EventHandler(this.button_PageOne_Click);
            // 
            // panel_PageContent
            // 
            this.panel_PageContent.Location = new System.Drawing.Point(34, 50);
            this.panel_PageContent.Name = "panel_PageContent";
            this.panel_PageContent.Size = new System.Drawing.Size(477, 212);
            this.panel_PageContent.TabIndex = 10;
            // 
            // radioButton_en
            // 
            this.radioButton_en.AutoSize = true;
            this.radioButton_en.Location = new System.Drawing.Point(97, 280);
            this.radioButton_en.Name = "radioButton_en";
            this.radioButton_en.Size = new System.Drawing.Size(54, 16);
            this.radioButton_en.TabIndex = 9;
            this.radioButton_en.TabStop = true;
            this.radioButton_en.Tag = "En_Us";
            this.radioButton_en.Text = "En_Us";
            this.radioButton_en.UseVisualStyleBackColor = true;
            this.radioButton_en.CheckedChanged += new System.EventHandler(this.onLanguageCheckChanged);
            // 
            // radioButton_ch
            // 
            this.radioButton_ch.AutoSize = true;
            this.radioButton_ch.Location = new System.Drawing.Point(34, 280);
            this.radioButton_ch.Name = "radioButton_ch";
            this.radioButton_ch.Size = new System.Drawing.Size(57, 16);
            this.radioButton_ch.TabIndex = 8;
            this.radioButton_ch.TabStop = true;
            this.radioButton_ch.Tag = "Zh_Tw";
            this.radioButton_ch.Text = "Zh_Tw";
            this.radioButton_ch.UseVisualStyleBackColor = true;
            this.radioButton_ch.CheckedChanged += new System.EventHandler(this.onLanguageCheckChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 316);
            this.Controls.Add(this.button_PageTwo);
            this.Controls.Add(this.button_PageOne);
            this.Controls.Add(this.panel_PageContent);
            this.Controls.Add(this.radioButton_en);
            this.Controls.Add(this.radioButton_ch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_PageTwo;
        private System.Windows.Forms.Button button_PageOne;
        private System.Windows.Forms.Panel panel_PageContent;
        private System.Windows.Forms.RadioButton radioButton_en;
        private System.Windows.Forms.RadioButton radioButton_ch;
    }
}

