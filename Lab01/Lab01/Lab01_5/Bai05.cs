using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab01_5
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
            this.Text = "Phần mềm quản lý điểm"; //đổi tên form
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxKetQua.Visible = true; 
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string input = txtDanhSachDiem.Text.Trim();
            string[] diemChuoi = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double[] diemArray;

            try
            {
                diemArray = diemChuoi.Select(s =>
                    double.Parse(s, System.Globalization.CultureInfo.InvariantCulture)  //nhận số thập phân
                ).ToArray();

                if (diemArray.Any(d => d > 10))
                {
                    MessageBox.Show("Điểm không hợp lệ! Vui lòng nhập lại.",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập danh sách điểm hợp lệ (sử dụng khoảng trắng để phân tách)!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBoxKetQua.Items.Clear();
            for (int i = 0; i < diemArray.Length; i += 2)
            {
                string mon1 = $"Môn {i + 1}: {diemArray[i]:0.0}d";
                string mon2 = (i + 1 < diemArray.Length) ? $"Môn {i + 2}: {diemArray[i + 1]:0.0}d" : "";
                listBoxKetQua.Items.Add($"{mon1}\t\t{mon2}");
            }

            double diemTB = diemArray.Average();
            double diemCaoNhat = diemArray.Max();
            double diemThapNhat = diemArray.Min();
            int soMonDau = diemArray.Count(d => d >= 5);
            int soMonRot = diemArray.Count(d => d < 5);

            lblDiemTB.Text = $"Điểm trung bình: {diemTB:F2}";
            lblDiemCaoNhat.Text = $"Môn có điểm cao nhất: {diemCaoNhat} d";
            lblDiemThapNhat.Text = $"Môn có điểm thấp nhất: {diemThapNhat} d";
            lblSoMonDau.Text = $"Số môn đậu: {soMonDau}";
            lblSoMonRot.Text = $"Số môn không đậu: {soMonRot}";

            if (diemTB >= 8 && diemArray.All(d => d >= 5))
                lblXepLoai.Text = "Xếp loại học lực: Giỏi";
            else if (diemTB >= 6.5 && diemArray.All(d => d >= 5))
                lblXepLoai.Text = "Xếp loại học lực: Khá";
            else if (diemTB >= 5 && diemArray.All(d => d >= 3.5))
                lblXepLoai.Text = "Xếp loại học lực: Trung bình";
            else
                lblXepLoai.Text = "Xếp loại học lực: Yếu";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDanhSachDiem.Clear();
            listBoxKetQua.Items.Clear();
            lblDiemTB.Text = "Điểm trung bình:";
            lblDiemCaoNhat.Text = "Môn có điểm cao nhất:";
            lblDiemThapNhat.Text = "Môn có điểm thấp nhất:";
            lblSoMonDau.Text = "Số môn đậu:";
            lblSoMonRot.Text = "Số môn không đậu:";
            lblXepLoai.Text = "Xếp loại học lực:";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxKetQua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
