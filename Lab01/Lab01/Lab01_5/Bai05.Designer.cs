namespace Lab01_5
{
    partial class Bai05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai05));
            this.txtDanhSachDiem = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.listBoxKetQua = new System.Windows.Forms.ListBox();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblDiemCaoNhat = new System.Windows.Forms.Label();
            this.lblDiemThapNhat = new System.Windows.Forms.Label();
            this.lblSoMonDau = new System.Windows.Forms.Label();
            this.lblSoMonRot = new System.Windows.Forms.Label();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDanhSachDiem
            // 
            this.txtDanhSachDiem.Location = new System.Drawing.Point(266, 98);
            this.txtDanhSachDiem.Name = "txtDanhSachDiem";
            this.txtDanhSachDiem.Size = new System.Drawing.Size(293, 22);
            this.txtDanhSachDiem.TabIndex = 0;
            // 
            // btnXuat
            // 
            this.btnXuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuat.BackgroundImage")));
            this.btnXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.Location = new System.Drawing.Point(597, 98);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(113, 57);
            this.btnXuat.TabIndex = 1;
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(592, 191);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 62);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(592, 291);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 60);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // listBoxKetQua
            // 
            this.listBoxKetQua.BackColor = System.Drawing.Color.White;
            this.listBoxKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxKetQua.Enabled = false;
            this.listBoxKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.listBoxKetQua.FormattingEnabled = true;
            this.listBoxKetQua.ItemHeight = 20;
            this.listBoxKetQua.Location = new System.Drawing.Point(80, 141);
            this.listBoxKetQua.Name = "listBoxKetQua";
            this.listBoxKetQua.Size = new System.Drawing.Size(479, 182);
            this.listBoxKetQua.TabIndex = 4;
            this.listBoxKetQua.SelectedIndexChanged += new System.EventHandler(this.listBoxKetQua_SelectedIndexChanged);
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.BackColor = System.Drawing.Color.White;
            this.lblDiemTB.Location = new System.Drawing.Point(77, 335);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(101, 16);
            this.lblDiemTB.TabIndex = 5;
            this.lblDiemTB.Text = "Điểm trung bình:";
            // 
            // lblDiemCaoNhat
            // 
            this.lblDiemCaoNhat.AutoSize = true;
            this.lblDiemCaoNhat.BackColor = System.Drawing.Color.White;
            this.lblDiemCaoNhat.Location = new System.Drawing.Point(77, 368);
            this.lblDiemCaoNhat.Name = "lblDiemCaoNhat";
            this.lblDiemCaoNhat.Size = new System.Drawing.Size(141, 16);
            this.lblDiemCaoNhat.TabIndex = 6;
            this.lblDiemCaoNhat.Text = "Môn có điểm cao nhất:";
            // 
            // lblDiemThapNhat
            // 
            this.lblDiemThapNhat.AutoSize = true;
            this.lblDiemThapNhat.BackColor = System.Drawing.Color.White;
            this.lblDiemThapNhat.Location = new System.Drawing.Point(77, 398);
            this.lblDiemThapNhat.Name = "lblDiemThapNhat";
            this.lblDiemThapNhat.Size = new System.Drawing.Size(144, 16);
            this.lblDiemThapNhat.TabIndex = 7;
            this.lblDiemThapNhat.Text = "Môn có điểm thấp nhất:";
            // 
            // lblSoMonDau
            // 
            this.lblSoMonDau.AutoSize = true;
            this.lblSoMonDau.BackColor = System.Drawing.Color.White;
            this.lblSoMonDau.Location = new System.Drawing.Point(338, 368);
            this.lblSoMonDau.Name = "lblSoMonDau";
            this.lblSoMonDau.Size = new System.Drawing.Size(82, 16);
            this.lblSoMonDau.TabIndex = 8;
            this.lblSoMonDau.Text = "Số môn đậu:";
            // 
            // lblSoMonRot
            // 
            this.lblSoMonRot.AutoSize = true;
            this.lblSoMonRot.BackColor = System.Drawing.Color.White;
            this.lblSoMonRot.Location = new System.Drawing.Point(337, 398);
            this.lblSoMonRot.Name = "lblSoMonRot";
            this.lblSoMonRot.Size = new System.Drawing.Size(122, 16);
            this.lblSoMonRot.TabIndex = 9;
            this.lblSoMonRot.Text = "Số môn không đậu:";
            // 
            // lblXepLoai
            // 
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.BackColor = System.Drawing.Color.White;
            this.lblXepLoai.Location = new System.Drawing.Point(337, 335);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(104, 16);
            this.lblXepLoai.TabIndex = 10;
            this.lblXepLoai.Text = "Xếp loại học lực:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(236, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 51);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(80, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 51);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblXepLoai);
            this.Controls.Add(this.lblSoMonRot);
            this.Controls.Add(this.lblSoMonDau);
            this.Controls.Add(this.lblDiemThapNhat);
            this.Controls.Add(this.lblDiemCaoNhat);
            this.Controls.Add(this.lblDiemTB);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.txtDanhSachDiem);
            this.Controls.Add(this.listBoxKetQua);
            this.Name = "Bai05";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDanhSachDiem;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListBox listBoxKetQua;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label lblDiemCaoNhat;
        private System.Windows.Forms.Label lblDiemThapNhat;
        private System.Windows.Forms.Label lblSoMonDau;
        private System.Windows.Forms.Label lblSoMonRot;
        private System.Windows.Forms.Label lblXepLoai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

