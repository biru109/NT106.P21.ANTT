namespace Main
{
    partial class Form1
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
            this.bai1 = new System.Windows.Forms.Button();
            this.bai2 = new System.Windows.Forms.Button();
            this.bai3 = new System.Windows.Forms.Button();
            this.bai4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bai1
            // 
            this.bai1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai1.Location = new System.Drawing.Point(114, 113);
            this.bai1.Name = "bai1";
            this.bai1.Size = new System.Drawing.Size(249, 118);
            this.bai1.TabIndex = 0;
            this.bai1.Text = "Bài 01";
            this.bai1.UseVisualStyleBackColor = true;
            this.bai1.Click += new System.EventHandler(this.bai1_Click);
            // 
            // bai2
            // 
            this.bai2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai2.Location = new System.Drawing.Point(431, 113);
            this.bai2.Name = "bai2";
            this.bai2.Size = new System.Drawing.Size(249, 118);
            this.bai2.TabIndex = 1;
            this.bai2.Text = "Bài 02";
            this.bai2.UseVisualStyleBackColor = true;
            this.bai2.Click += new System.EventHandler(this.bai2_Click);
            // 
            // bai3
            // 
            this.bai3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai3.Location = new System.Drawing.Point(114, 270);
            this.bai3.Name = "bai3";
            this.bai3.Size = new System.Drawing.Size(249, 118);
            this.bai3.TabIndex = 2;
            this.bai3.Text = "Bài 03";
            this.bai3.UseVisualStyleBackColor = true;
            this.bai3.Click += new System.EventHandler(this.bai3_Click);
            // 
            // bai4
            // 
            this.bai4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai4.Location = new System.Drawing.Point(431, 270);
            this.bai4.Name = "bai4";
            this.bai4.Size = new System.Drawing.Size(249, 118);
            this.bai4.TabIndex = 3;
            this.bai4.Text = "Bài 04";
            this.bai4.UseVisualStyleBackColor = true;
            this.bai4.Click += new System.EventHandler(this.bai4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "LAB03 - NT106.P21.ANTT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Main.Properties.Resources.nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bai4);
            this.Controls.Add(this.bai3);
            this.Controls.Add(this.bai2);
            this.Controls.Add(this.bai1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bai1;
        private System.Windows.Forms.Button bai2;
        private System.Windows.Forms.Button bai3;
        private System.Windows.Forms.Button bai4;
        private System.Windows.Forms.Label label1;
    }
}

