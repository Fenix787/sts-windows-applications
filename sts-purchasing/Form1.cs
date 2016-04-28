using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace sts_purchasing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Write("test");
            try
            {
                var client = new UdpClient();

                client.Connect("blitz.cs.niu.edu",4446);

                Console.Write("connected");

                // send data
                string message = "3647839:Bell South:2,800,000.00";

                client.Send(Encoding.ASCII.GetBytes(message), Encoding.ASCII.GetByteCount(message));
                Console.Write("Sent");

                // then receive data
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);

                Byte[] rcBtye = client.Receive(ref ep);
                string rcString = Encoding.ASCII.GetString(rcBtye);

                Console.Write(rcString);

            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }
    }
}
