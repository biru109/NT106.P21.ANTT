using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace LAB04
{
    public partial class FormCau04 : Form
    {
        private WebClient client;

        public FormCau04()
        {
            InitializeComponent();

            // Tooltip cho nút
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(buttonGo, "Đi tới trang web");
            toolTip1.SetToolTip(buttonViewSource, "Xem mã nguồn HTML");
            toolTip1.SetToolTip(buttonDownload, "Tải file HTML");
            toolTip1.SetToolTip(buttonDownloadAll, "Tải tất cả tài nguyên");
            toolTip1.SetToolTip(button1, "Đóng chương trình");

            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            client.Headers.Add("user-agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
                "(KHTML, like Gecko) Chrome/89.0.4389.82 Safari/537.36");

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonGo.PerformClick();
        }

        private string EnsureHttp(string url)
        {
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                return "http://" + url;
            return url;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            string url = EnsureHttp(textBoxURL.Text);
            if (!string.IsNullOrEmpty(url))
                webBrowser1.Navigate(url);
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                string url = EnsureHttp(textBoxURL.Text);
                string htmlContent = client.DownloadString(url);
                string path = Path.Combine(Application.StartupPath, "downloaded.html");

                File.WriteAllText(path, htmlContent, Encoding.UTF8);
                MessageBox.Show("Tải HTML thành công!\nĐã lưu tại: " + path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải HTML: " + ex.Message);
            }
        }

        private void buttonViewSource_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Document != null)
            {
                string htmlSource = webBrowser1.DocumentText;
                SourceForm sourceForm = new SourceForm(htmlSource);
                sourceForm.Show();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu trang web để hiển thị.");
            }
        }

        private void buttonDownloadAll_Click(object sender, EventArgs e)
        {
            try
            {
                string url = EnsureHttp(textBoxURL.Text);
                string htmlContent = client.DownloadString(url);

                File.WriteAllText(Path.Combine(Application.StartupPath, "downloaded.html"), htmlContent, Encoding.UTF8);

                DownloadResources(htmlContent, url);
                DownloadAdditionalFiles(htmlContent, url);

                MessageBox.Show("Tải HTML và tài nguyên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải tất cả tài nguyên: " + ex.Message);
            }
        }

        private void DownloadResources(string htmlContent, string baseUrl)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlContent);

            var imgNodes = doc.DocumentNode.SelectNodes("//img");
            if (imgNodes != null)
            {
                string imgFolder = Path.Combine(Application.StartupPath, "images");
                Directory.CreateDirectory(imgFolder);

                foreach (var img in imgNodes)
                {
                    string imgSrc = img.GetAttributeValue("src", "");
                    if (!string.IsNullOrEmpty(imgSrc))
                    {
                        try
                        {
                            Uri imgUri = new Uri(new Uri(baseUrl), imgSrc);
                            string imgName = Path.GetFileName(imgUri.LocalPath);
                            string imgPath = Path.Combine(imgFolder, imgName);

                            client.DownloadFile(imgUri, imgPath);
                            Console.WriteLine($"Đã tải hình: {imgUri}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Lỗi tải hình: {imgSrc} => {ex.Message}");
                        }
                    }
                }
            }
        }

        private void DownloadAdditionalFiles(string htmlContent, string baseUrl)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlContent);

            // Download CSS
            var cssNodes = doc.DocumentNode.SelectNodes("//link[@rel='stylesheet']");
            if (cssNodes != null)
            {
                string cssFolder = Path.Combine(Application.StartupPath, "styles");
                Directory.CreateDirectory(cssFolder);

                foreach (var css in cssNodes)
                {
                    string cssHref = css.GetAttributeValue("href", "");
                    if (!string.IsNullOrEmpty(cssHref))
                    {
                        try
                        {
                            Uri cssUri = new Uri(new Uri(baseUrl), cssHref);
                            string cssName = Path.GetFileName(cssUri.LocalPath);
                            string cssPath = Path.Combine(cssFolder, cssName);

                            client.DownloadFile(cssUri, cssPath);
                            Console.WriteLine($"Đã tải CSS: {cssUri}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Lỗi tải CSS: {cssHref} => {ex.Message}");
                        }
                    }
                }
            }

            // Download JS
            var jsNodes = doc.DocumentNode.SelectNodes("//script[@src]");
            if (jsNodes != null)
            {
                string jsFolder = Path.Combine(Application.StartupPath, "scripts");
                Directory.CreateDirectory(jsFolder);

                foreach (var js in jsNodes)
                {
                    string jsSrc = js.GetAttributeValue("src", "");
                    if (!string.IsNullOrEmpty(jsSrc))
                    {
                        try
                        {
                            Uri jsUri = new Uri(new Uri(baseUrl), jsSrc);
                            string jsName = Path.GetFileName(jsUri.LocalPath);
                            string jsPath = Path.Combine(jsFolder, jsName);

                            client.DownloadFile(jsUri, jsPath);
                            Console.WriteLine($"Đã tải JS: {jsUri}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Lỗi tải JS: {jsSrc} => {ex.Message}");
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        { 

        }
    }
}
