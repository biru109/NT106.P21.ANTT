using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab05
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
            textBoxPass.UseSystemPasswordChar = true;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true; //chọn nhiều file
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxFilePath.Text = string.Join(Environment.NewLine, ofd.FileNames);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFrom.Text) || string.IsNullOrWhiteSpace(textBoxTo.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ email người gửi/người nhận.");
                    return;
                }

                if (!textBoxTo.Text.Contains("@") || !textBoxTo.Text.Contains("."))
                {
                    MessageBox.Show("Địa chỉ email người nhận không hợp lệ.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxPass.Text))
                {
                    MessageBox.Show("Vui lòng nhập Pass.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(richTextBoxBody.Text))
                {
                    MessageBox.Show("Vui lòng nhập nội dung email.");
                    return;
                }

                // === GỬI EMAIL ===
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(textBoxFrom.Text.Trim(), textBoxPass.Text.Trim());

                MailMessage message = new MailMessage();
                message.From = new MailAddress(textBoxFrom.Text.Trim());
                message.To.Add(textBoxTo.Text.Trim());
                message.Subject = textBoxSubject.Text.Trim();
                message.Body = richTextBoxBody.Text.Trim();
                message.IsBodyHtml = false;

                // Xử lý nhiều file đính kèm
                // Xử lý nhiều file đính kèm
                if (!string.IsNullOrWhiteSpace(textBoxFilePath.Text))
                {
                    string[] files = textBoxFilePath.Lines; // mỗi dòng là 1 file
                    foreach (var file in files)
                    {
                        if (File.Exists(file.Trim()))
                        {
                            message.Attachments.Add(new Attachment(file.Trim()));
                        }
                    }
                }


                smtp.Send(message);
                MessageBox.Show("✅ Gửi email thành công!");
            }
            catch (SmtpException smtpEx)
            {
                if (smtpEx.StatusCode == SmtpStatusCode.GeneralFailure || smtpEx.Message.Contains("5.7.0"))
                {
                    MessageBox.Show("❌ Xác thực thất bại: sai mật khẩu hoặc Gmail chặn truy cập.");
                }
                else
                {
                    MessageBox.Show("❌ SMTP lỗi: " + smtpEx.Message);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("❌ Địa chỉ email không đúng định dạng.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi gửi mail: " + ex.Message);
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = !checkBoxShowPass.Checked;
        }
    }
}
