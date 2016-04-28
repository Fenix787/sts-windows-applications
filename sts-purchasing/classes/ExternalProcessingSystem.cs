using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace sts_purchasing
{
    public class ExternalProcessingSystem
    {
        string host = "blitz.cs.niu.edu";
        Int32 port = 4446;

        public string[] processsComission(int poid, string customer, double total)
        {
            try
            {
                var client = new UdpClient();
                client.Connect(host, port);

                // compose message
                string message = poid.ToString() + ":" +  customer + ":" + total.ToString();

                // send message
                client.Send(Encoding.ASCII.GetBytes(message), Encoding.ASCII.GetByteCount(message));

                // get response
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);

                // convert to string
                Byte[] rcBtye = client.Receive(ref ep);
                string rcString = Encoding.ASCII.GetString(rcBtye);

                // disconnect from server
                client.Close();

                // return split response
                return rcString.Split(':');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new string[0];
            }
        }
    }
}
