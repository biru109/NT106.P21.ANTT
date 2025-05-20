using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Cau01;
using Cau02;
using Cau03;
using LAB04;



namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCau01 formBai01 = new FormCau01();
            formBai01.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCau02 formBai02 = new FormCau02();
            formBai02.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCau03 formBai03 = new FormCau03();
            formBai03.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCau04 formBai04 = new FormCau04();
            formBai04.Show();
        }
    }
}
