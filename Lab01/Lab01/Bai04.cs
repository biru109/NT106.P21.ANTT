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
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
            chon.DropDownStyle = ComboBoxStyle.DropDownList;
            sang.DropDownStyle = ComboBoxStyle.DropDownList;
            ketqua.ReadOnly = true;
        }

        private void thuchien_Click(object sender, EventArgs e)
        {
            try
            {
                string input = nhapso.Text;
                string from = chon.SelectedItem.ToString();
                string to = sang.SelectedItem.ToString();

                string result = convertnumber(input, from, to);
                ketqua.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chuyển đổi thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void chon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            chon.SelectedIndex = -1;
            sang.SelectedIndex = -1;
            nhapso.Clear();
            ketqua.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string convertnumber (string input, string from, string to)
        {
            int number = 0;
            bool isValid = false;
            if (from == "Binary")
                isValid = int.TryParse(input, System.Globalization.NumberStyles.AllowHexSpecifier, null, out number);
            else if (from == "Decimal")
                isValid = int.TryParse(input, out number);
            else if (from == "Hexa")
                isValid = int.TryParse(input, System.Globalization.NumberStyles.HexNumber, null, out number);

            if (!isValid)
                return "Lỗi nhập liệu!";


            if (from == "Binary")
                number = Convert.ToInt32(input, 2);
            else if (from == "Decimal")
                number = int.Parse(input);
            else if (from == "Hexa")
                number = Convert.ToInt32(input ,16);

            if (to == "Binary")
                return Convert.ToString(number, 2);
            else if (to == "Decimal")
                return number.ToString();
            else if (to == "Hexa")
                return Convert.ToString(number, 16).ToUpper();
            return "Lỗi!!";


        }

        private void sang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
