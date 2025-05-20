namespace Lab02
{
    partial class Lab02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab02));
            this.Bai01 = new System.Windows.Forms.Button();
            this.Bai02 = new System.Windows.Forms.Button();
            this.Bai03 = new System.Windows.Forms.Button();
            this.Bai04 = new System.Windows.Forms.Button();
            this.Bai05 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bai01
            // 
            this.Bai01.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai01.Location = new System.Drawing.Point(150, 146);
            this.Bai01.Name = "Bai01";
            this.Bai01.Size = new System.Drawing.Size(240, 78);
            this.Bai01.TabIndex = 0;
            this.Bai01.Text = "Bài 01";
            this.Bai01.UseVisualStyleBackColor = true;
            this.Bai01.Click += new System.EventHandler(this.Bai01_Click);
            // 
            // Bai02
            // 
            this.Bai02.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai02.Location = new System.Drawing.Point(544, 146);
            this.Bai02.Name = "Bai02";
            this.Bai02.Size = new System.Drawing.Size(240, 78);
            this.Bai02.TabIndex = 1;
            this.Bai02.Text = "Bài 02";
            this.Bai02.UseVisualStyleBackColor = true;
            // 
            // Bai03
            // 
            this.Bai03.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai03.Location = new System.Drawing.Point(150, 275);
            this.Bai03.Name = "Bai03";
            this.Bai03.Size = new System.Drawing.Size(240, 78);
            this.Bai03.TabIndex = 2;
            this.Bai03.Text = "Bài 03";
            this.Bai03.UseVisualStyleBackColor = true;
            // 
            // Bai04
            // 
            this.Bai04.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai04.Location = new System.Drawing.Point(544, 275);
            this.Bai04.Name = "Bai04";
            this.Bai04.Size = new System.Drawing.Size(240, 78);
            this.Bai04.TabIndex = 3;
            this.Bai04.Text = "Bài 04";
            this.Bai04.UseVisualStyleBackColor = true;
            // 
            // Bai05
            // 
            this.Bai05.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bai05.Location = new System.Drawing.Point(348, 381);
            this.Bai05.Name = "Bai05";
            this.Bai05.Size = new System.Drawing.Size(240, 78);
            this.Bai05.TabIndex = 4;
            this.Bai05.Text = "Bài 05";
            this.Bai05.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(221, 57);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(515, 50);
            this.title.TabIndex = 5;
            this.title.Text = "NT106.P21.ANTT.1 - LAB02";
            // 
            // Lab02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(936, 507);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Bai05);
            this.Controls.Add(this.Bai04);
            this.Controls.Add(this.Bai03);
            this.Controls.Add(this.Bai02);
            this.Controls.Add(this.Bai01);
            this.Name = "Lab02";
            this.Text = "Lab02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bai01;
        private System.Windows.Forms.Button Bai02;
        private System.Windows.Forms.Button Bai03;
        private System.Windows.Forms.Button Bai04;
        private System.Windows.Forms.Button Bai05;
        private System.Windows.Forms.Label title;
    }
}

