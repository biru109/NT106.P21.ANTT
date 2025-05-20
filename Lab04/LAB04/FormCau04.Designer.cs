namespace LAB04
{
    partial class FormCau04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCau04));
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonViewSource = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDownloadAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(48, 14);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(527, 21);
            this.textBoxURL.TabIndex = 0;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // buttonGo
            // 
            this.buttonGo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGo.BackgroundImage")));
            this.buttonGo.Location = new System.Drawing.Point(634, 65);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(37, 40);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDownload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDownload.BackgroundImage")));
            this.buttonDownload.Location = new System.Drawing.Point(635, 196);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(36, 38);
            this.buttonDownload.TabIndex = 2;
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonViewSource
            // 
            this.buttonViewSource.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonViewSource.BackgroundImage")));
            this.buttonViewSource.Location = new System.Drawing.Point(635, 133);
            this.buttonViewSource.Name = "buttonViewSource";
            this.buttonViewSource.Size = new System.Drawing.Size(37, 39);
            this.buttonViewSource.TabIndex = 3;
            this.buttonViewSource.UseVisualStyleBackColor = true;
            this.buttonViewSource.Click += new System.EventHandler(this.buttonViewSource_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 40);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(18, 19);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(610, 383);
            this.webBrowser1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL:";
            // 
            // buttonDownloadAll
            // 
            this.buttonDownloadAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDownloadAll.BackgroundImage")));
            this.buttonDownloadAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadAll.Location = new System.Drawing.Point(619, 285);
            this.buttonDownloadAll.Name = "buttonDownloadAll";
            this.buttonDownloadAll.Size = new System.Drawing.Size(76, 63);
            this.buttonDownloadAll.TabIndex = 6;
            this.buttonDownloadAll.UseVisualStyleBackColor = true;
            this.buttonDownloadAll.Click += new System.EventHandler(this.buttonDownloadAll_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(626, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDownloadAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.buttonViewSource);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textBoxURL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonViewSource;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDownloadAll;
        private System.Windows.Forms.Button button1;
    }
}

