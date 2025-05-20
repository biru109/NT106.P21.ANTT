using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai04;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bai1_Click(object sender, EventArgs e)
        {
            var f = new Cau1.Cau1_Client();
            f.Show();
        }

        private void bai2_Click(object sender, EventArgs e)
        {
            var f = new cau2.Form1();
            f.Show();
        }

        private void bai3_Click(object sender, EventArgs e)
        {
            var f = new Bai03.ServerForm();
            f.Show();
        }

        private void bai4_Click(object sender, EventArgs e)
        {
            var f = new Bai04.Form1();
            f.Show();

        }
    }
}
