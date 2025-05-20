using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form2 : Form
    {
        TcpClient client;
        NetworkStream stream;
        string userName;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("127.0.0.1", 12345); // IP của server
                stream = client.GetStream();
                userName = txtName.Text;

                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();

                btnConnect.Enabled = false;
                ShowMessage("Đã kết nối đến server!");
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server.");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text)) return;

            string message = $"{userName}: {txtMessage.Text.Trim()}";
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream.Write(buffer, 0, buffer.Length);
            txtMessage.Clear();
        }


        void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                try
                {
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
                    ShowMessage(msg);
                }
                catch
                {
                    break;
                }
            }
        }

        void ShowMessage(string msg)
        {
            if (lstChat.InvokeRequired)
            {
                lstChat.Invoke(new Action(() => lstChat.Items.Add(msg)));
            }
            else
            {
                lstChat.Items.Add(msg);
            }
        }


    }
}
