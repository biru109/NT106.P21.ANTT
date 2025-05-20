using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
            solon.ReadOnly = true;
            sonho.ReadOnly = true;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tim_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(somot.Text);
                double num2 = double.Parse(sohai.Text);
                double num3 = double.Parse(soba.Text);

                double max = Math.Max(num1, Math.Max(num2, num3));
                double min = Math.Min(num1, Math.Min(num2, num3));

                solon.Text = max.ToString();
                sonho.Text = min.ToString();

            }

            catch
            {
                MessageBox.Show("Vui lòng nhập số họp lệ!", "Lỗi nhập lệnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            somot.Clear();
            sohai.Clear();
            soba.Clear();
            solon.Clear();
            sonho.Clear();
        }

        private void somot_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Cho phép nhập số, Backspace, dấu chấm (.) hoặc dấu trừ (-)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }

            // Chỉ cho phép một dấu chấm thập phân
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // Chặn nếu đã có dấu chấm
            }
        }

        private void solon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
