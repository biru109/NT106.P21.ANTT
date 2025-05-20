namespace Cau03
{
    partial class FormCau03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.htmlcontent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(27, 12);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(569, 31);
            this.txtUrl.TabIndex = 0;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(27, 76);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(569, 31);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(696, 14);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(187, 47);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "DOWNLOAD";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "XÓA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(696, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "THOÁT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // htmlcontent
            // 
            this.htmlcontent.Location = new System.Drawing.Point(32, 141);
            this.htmlcontent.Multiline = true;
            this.htmlcontent.Name = "htmlcontent";
            this.htmlcontent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.htmlcontent.Size = new System.Drawing.Size(564, 327);
            this.htmlcontent.TabIndex = 6;
            // 
            // Cau03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 480);
            this.Controls.Add(this.htmlcontent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.txtUrl);
            this.Name = "Cau03";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox htmlcontent;
    }
}

