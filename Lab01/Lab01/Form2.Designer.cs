namespace Lab01
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.SoHang1 = new System.Windows.Forms.TextBox();
            this.SoHang2 = new System.Windows.Forms.MaskedTextBox();
            this.Tong = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoHang1
            // 
            this.SoHang1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            this.SoHang1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoHang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoHang1.ForeColor = System.Drawing.Color.Black;
            this.SoHang1.Location = new System.Drawing.Point(434, 200);
            this.SoHang1.Name = "SoHang1";
            this.SoHang1.Size = new System.Drawing.Size(300, 38);
            this.SoHang1.TabIndex = 0;
            this.SoHang1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.SoHang1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoHang1_KeyPress);
            // 
            // SoHang2
            // 
            this.SoHang2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            this.SoHang2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoHang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoHang2.Location = new System.Drawing.Point(434, 264);
            this.SoHang2.Name = "SoHang2";
            this.SoHang2.Size = new System.Drawing.Size(300, 38);
            this.SoHang2.TabIndex = 1;
            this.SoHang2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SoHang2_MaskInputRejected);
            this.SoHang2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoHang2_KeyPress);
            // 
            // Tong
            // 
            this.Tong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            this.Tong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Tong.Location = new System.Drawing.Point(434, 332);
            this.Tong.Name = "Tong";
            this.Tong.Size = new System.Drawing.Size(300, 38);
            this.Tong.TabIndex = 2;
            this.Tong.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Tong_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(142)))), ((int)(((byte)(177)))));
            this.label1.Font = new System.Drawing.Font("Stencil", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(216, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "SIMPLE CALCULATOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số hạng thứ nhất:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số hạng thứ hai:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(99)))), ((int)(((byte)(126)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(521, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tính toán";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete.Location = new System.Drawing.Point(346, 386);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(110, 78);
            this.delete.TabIndex = 8;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.CausesValidation = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(213, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 88);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(950, 521);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tong);
            this.Controls.Add(this.SoHang2);
            this.Controls.Add(this.SoHang1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SoHang1;
        private System.Windows.Forms.MaskedTextBox SoHang2;
        private System.Windows.Forms.MaskedTextBox Tong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button2;
    }
}