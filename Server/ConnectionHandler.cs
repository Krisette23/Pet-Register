using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ConnectionHandler
    {
        BinaryReader reader;
        BinaryWriter writer;
        TcpClient client = new TcpClient();
        ConnectionHandler()
        {
            reader = new BinaryReader(client.GetStream());
            writer = new BinaryWriter(client.GetStream());
        }
   
    }
}
