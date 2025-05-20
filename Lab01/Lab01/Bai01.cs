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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Tong.ReadOnly = true;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SoHang2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Tong_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long inum1, inum2;
            long sum = 0;
            inum1 = Int32.Parse(SoHang1.Text);
            inum2 = Int32.Parse(SoHang2.Text);
            
            sum = inum1 + inum2;
            Tong.Text = sum.ToString();
        }

        private void SoHang1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                MessageBox.Show("Chỉ được nhập số nguyên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            // Cho phép dấu '-' nhưng chỉ ở vị trí đầu tiên
            if (e.KeyChar == '-' && SoHang1.Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void SoHang2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')

            {
                MessageBox.Show("Chỉ được nhập số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // Ngăn ký tự được nhập vào TextBox
            }

            if (e.KeyChar == '-' && SoHang2.Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SoHang1.Clear();
            SoHang2.Clear();
            Tong.Clear();
            SoHang1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
