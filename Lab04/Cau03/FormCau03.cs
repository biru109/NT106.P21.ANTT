using System;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace Cau03
{
    public partial class FormCau03 : Form
    {
        public FormCau03()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim(); // địa chỉ url cần tải
            string filePath = txtFilePath.Text.Trim(); // path file lưu trữ

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Vui lòng nhập URL và đường dẫn file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tải nội dung HTML của trang web
            string htmlContent = DownloadWebPage(url);

            // Hiển thị nội dung HTML trong TextBox
            htmlcontent.Text = htmlContent;

            // Lưu nội dung HTML vào file tại đường dẫn đã nhập
            SaveHtmlToFile(htmlContent, filePath);
        }

        private string DownloadWebPage(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    // Tải nội dung HTML từ URL
                    string htmlContent = client.DownloadString(url);
                    return htmlContent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải trang: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void SaveHtmlToFile(string htmlContent, string filePath)
        {
            try
            {
                // Kiểm tra nếu đường dẫn file hợp lệ (bỏ qua nếu không cần thiết)
                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Đường dẫn file không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ghi nội dung HTML vào file tại đường dẫn file
                File.WriteAllText(filePath, htmlContent);
                MessageBox.Show("Đã lưu nội dung HTML vào file: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUrl.Text = "";
            txtFilePath.Text = "";  
            htmlcontent.Text = "";  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



//http://example.com
