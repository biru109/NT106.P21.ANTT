using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class ServerForm : Form
    {
        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;
        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread listenerThread = new Thread(StartListening);
            listenerThread.Start();
            btnListen.Enabled = false;
        }

        private void StartListening()
        {
            listener = new TcpListener(IPAddress.Any, 12345);
            listener.Start();
            ShowMessage("Server started. Waiting for clients...");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient(); // Không lưu ở biến toàn cục nữa
                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.Start();
            }
        }

        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    ShowMessage(message);
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Client disconnected or error: {ex.Message}");
            }
            finally
            {
                stream.Close();
                client.Close();
            }
        }


        private void ShowMessage(string msg)
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

        private void btnOpenClient_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }
    }
}
