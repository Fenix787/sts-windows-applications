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
                string[] data = new string[3];
                var client = new UdpClient();
                client.Connect(host, port);

                // compose message
                string message = poid.ToString("D8") + ":" +  customer + ":" + total.ToString();

                // send message
                client.Send(Encoding.ASCII.GetBytes(message), Encoding.ASCII.GetByteCount(message));

                // get response
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);

                // convert to string
                Byte[] rcBtye = client.Receive(ref ep);
                string rcString = Encoding.ASCII.GetString(rcBtye);

                // disconnect from server
                client.Close();
                Console.WriteLine("rc str | " + rcString);

                // isolate the date
                data[0] = rcString.Substring(0, 28);
                rcString = rcString.Substring(30, rcString.Length-30);

                // isolate the confirmation number and comission precentage
                string [] splits = rcString.Split(':');
                if(splits.Count() > 5)
                {
                    data[1] = "-1";
                    data[2] = "-1";
                }
                else
                {
                    // store confirmation number
                    data[1] = splits[1].Substring(1, splits[1].Length - 1);

                    // store comission without precentage
                    data[2] = splits[3].Substring(1, 2);
                }
                return data;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new string[0];
            }
        }
    }
}
