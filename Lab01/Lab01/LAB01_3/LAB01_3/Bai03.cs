using System;
using System.Windows.Forms;

namespace LAB01_3
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNhap.Text) && !int.TryParse(txtNhap.Text, out _))
            {
                txtNhap.Clear(); 
            }
        }


        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập một số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(txtNhap.Text, out int so) && so >= 0 && so <= 999999)
            {
                txtKetQua.Text = DocSoTiengViet(so);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số từ 0 đến 9999!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtKetQua.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string DocSoTiengViet(int so)
        {
            if (so == 0) return "Không";

            string[] soTiengViet = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            string ketQua = "";

            int hangNghin = so / 1000;
            int hangTram = (so % 1000) / 100;
            int hangChuc = (so % 100) / 10;
            int hangDonVi = so % 10;

            // Đọc hàng nghìn
            if (hangNghin > 0)
            {
                ketQua += soTiengViet[hangNghin] + " Nghìn ";
            }

            // Đọc hàng trăm
            if (hangTram > 0)
            {
                ketQua += soTiengViet[hangTram] + " Trăm ";
            }
            else if (hangNghin > 0 && (hangChuc > 0 || hangDonVi > 0))
            {
                ketQua += "Không Trăm ";
            }

            // Đọc hàng chục
            if (hangChuc > 1)
            {
                ketQua += soTiengViet[hangChuc] + " Mươi ";
                if (hangDonVi == 5) ketQua += "Lăm";
                else if (hangDonVi > 0) ketQua += soTiengViet[hangDonVi];
            }
            else if (hangChuc == 1)
            {
                ketQua += "Mười ";
                if (hangDonVi == 5) ketQua += "Lăm";
                else if (hangDonVi > 0) ketQua += soTiengViet[hangDonVi];
            }
            else if (hangChuc == 0 && hangDonVi > 0)
            {
                ketQua += "Lẻ " + soTiengViet[hangDonVi];
            }

            return ketQua.Trim();
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
