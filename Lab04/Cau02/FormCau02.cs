using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Cau02
{
    public partial class FormCau02 : Form
    {
        public FormCau02()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            string postData = txtData.Text.Trim();

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(postData))
            {
                MessageBox.Show("Vui lòng nhập URL và Dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gửi yêu cầu POST và lấy phản hồi từ server
            string responseFromServer = SendPostRequest(url, postData);

            // Hiển thị phản hồi trong TextBox
            txtResponse.Text = responseFromServer;
        }

        private string SendPostRequest(string url, string postData)
        {
            try
            {
                // Chuyển dữ liệu thành mảng byte
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                // Tạo WebRequest để gửi POST request
                WebRequest request = WebRequest.Create(url);
                request.Method = "POST";

                // Thiết lập Content-Type và Content-Length
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;

                // Ghi dữ liệu vào request stream
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                // Nhận phản hồi từ server
                WebResponse response = request.GetResponse();

                // Đọc dữ liệu từ response stream
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUrl.Text = "";         // xóa url
            txtData.Text = "";
            txtResponse.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

//http://httpbin.org/post name=Hong Bich Nhu & age=10
//http://httpbun.org/post


