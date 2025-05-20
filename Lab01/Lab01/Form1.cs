using LAB01_3;
using Lab01_5;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Bai01_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 bai01 = new Form2(); 
            bai01.Show();
        }

        private void Bai02_Click(object sender, EventArgs e)
        {
            Bai02 bai02 = new Bai02();
            bai02.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bai04_Click(object sender, EventArgs e)
        {
            Bai04 bai04 = new Bai04();
            bai04.Show();
        }

        private void Bai05_Click(object sender, EventArgs e)
        {
            Bai05 bai05 = new Bai05();
            bai05.Show();
        }

        private void Bai03_Click(object sender, EventArgs e)
        {
            Bai03 bai03 = new Bai03();
            bai03.Show();
        }
    }
}
