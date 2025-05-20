using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Cau01
{
    public partial class FormCau01 : Form
    {
        public FormCau01()
        {
            InitializeComponent();
        }

        private void btnGetHtml_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string htmlContent = GetHTML(url);
            txtResponse.Text = htmlContent;
        }

        private string GetHTML(string szUrl)
        {
            try
            {
                WebRequest request = WebRequest.Create(szUrl);
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                response.Close();
                return responseFromServer;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUrl.Text = "";         // xóa url
            txtResponse.Text = "";      // xóa nội dung get
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//http://httpbin.org/get
//http://requestbin.net
//http://www.webtretho.com/
