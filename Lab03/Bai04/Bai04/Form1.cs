using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private bool isRunning = false;
        private Thread serverThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                Thread serverThread = new Thread(StartServer);
                serverThread.Start();
                lblStatus.Text = "Status: Đang chạy...";
                btnStart.Enabled = false;
            }
        }

        void StartServer()
        {
            server = new TcpListener(IPAddress.Any, 12345);
            server.Start();

            while (isRunning)
            {
                TcpClient client = server.AcceptTcpClient();
                clients.Add(client);

                // Hiển thị log client mới kết nối
                IPEndPoint clientEndPoint = (IPEndPoint)client.Client.RemoteEndPoint;
                ShowMessage($"Client kết nối từ {clientEndPoint.Address}:{clientEndPoint.Port}");

                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.Start();
            }

        }


        void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            while (isRunning)
            {
                try
                {
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    if (bytes == 0) break;

                    string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
                    ShowMessage(msg);
                    BroadcastMessage(msg, client);
                }
                catch
                {
                    break;
                }
            }

            clients.Remove(client);
        }

        void BroadcastMessage(string message, TcpClient sender)
        {
            byte[] msg = Encoding.UTF8.GetBytes(message);
            foreach (TcpClient c in clients)
            {
                if (c != sender)
                {
                    try
                    {
                        c.GetStream().Write(msg, 0, msg.Length);
                    }
                    catch { }
                }
            }
        }

        void ShowMessage(string msg)
        {
            if (lstMessages.InvokeRequired)
            {
                lstMessages.Invoke(new Action(() => lstMessages.Items.Add(msg)));
            }
            else
            {
                lstMessages.Items.Add(msg);
            }
        }



        private void OpenClient_Click(object sender, EventArgs e)
        {
            Form2 client = new Form2();
            client.Show();
        }
    }
}
