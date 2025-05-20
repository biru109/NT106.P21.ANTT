using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt) | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                uitbx.Text = sr.ReadToEnd();
                fs.Close();
                format.Enabled = true;
                write.Enabled = true;
            }
        }

        private void format_Click(object sender, EventArgs e)
        {

        }

        private void write_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "(*.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK) 
            {
                
            }
        }
    }
}


/*private void writebtn_Click(object sender, EventArgs e)
{
    SaveFileDialog sfd = new SaveFileDialog();
    sfd.Filter = "(*.txt) | *.txt";

    if (sfd.ShowDialog() == DialogResult.OK)
    {
        FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
        StreamWriter sw = new StreamWriter(fs);
        sw.Write(uitbx.Text);
        sw.Close();
        fs.Close();
        uitbx.Clear();
        writebtn.Enabled = false;
    }
}*/