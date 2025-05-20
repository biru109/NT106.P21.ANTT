using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class ClientForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            client.Connect("127.0.0.1", 12345);
            stream = client.GetStream();
            btnConnect.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string msg = "Hello server!!!";
            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            stream.Write(buffer, 0, buffer.Length);
        }
    }
}
