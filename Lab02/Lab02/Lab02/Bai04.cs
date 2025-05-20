using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void nhap_Click(object sender, EventArgs e)
        {
            string MSSV = mssv.Text;
            string HoTen = hoten.Text;
            string DienThoai = dienthoai.Text;
            float Toan = float.Parse(toan.Text);
            float Van = float.Parse(van.Text);

            SinhVien sv = new SinhVien(MSSV, HoTen, DienThoai, Toan, Van);
            DanhSachSV.Add(sv);

            using (StreamWriter sw = new StreamWriter("input.txt", true))
            {
                sw.WriteLine($"{mssv};{hoten};{dienthoai};{toan};{van}");
            }

            MessageBox.Show("Đã lưu sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInput();
        }

        private void xuat_Click(object sender, EventArgs e)

        {
            // Đọc từ input.txt
            danhSachSV.Clear();
            if (File.Exists("input.txt"))
            {
                foreach (string line in File.ReadAllLines("input.txt"))
                {
                    string[] data = line.Split(';');
                    if (data.Length == 5)
                    {
                        SinhVien sv = new SinhVien(data[0], data[1], data[2], float.Parse(data[3]), float.Parse(data[4]));
                        danhSachSV.Add(sv);
                    }
                }
            }
        }

        private void hienthi_Click(object sender, EventArgs e)
        {
            FormHienThi formHienThi = new FormHienThi();
            formHienThi.Show();
        }            

        using (ExcelPackage excel = new ExcelPackage())
            {
                var ws = excel.Workbook.Worksheets.Add("DanhSachSV");
                ws.Cells[1, 1].Value = "MSSV";
                ws.Cells[1, 2].Value = "Họ Tên";
                ws.Cells[1, 3].Value = "Điện Thoại";
                ws.Cells[1, 4].Value = "Điểm Toán";
                ws.Cells[1, 5].Value = "Điểm Văn";
                ws.Cells[1, 6].Value = "Điểm Trung Bình";

                int row = 2;
                foreach (var sv in danhSachSV)
                {
                    ws.Cells[row, 1].Value = sv.mssv;
                    ws.Cells[row, 2].Value = sv.hoten;
                    ws.Cells[row, 3].Value = sv.dienthoai;
                    ws.Cells[row, 4].Value = sv.toan;
                    ws.Cells[row, 5].Value = sv.van;
                    ws.Cells[row, 6].Value = sv.TinhDTB();
                    row++;
                }

                File.WriteAllBytes("output.xlsx", excel.GetAsByteArray());
            }




















}