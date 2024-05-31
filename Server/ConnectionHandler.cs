﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ConnectionHandler
    {
        BinaryFormatter binFormatter = new BinaryFormatter();
        private NetworkStream networkStream;
        ConnectionHandler()
        {
            
        }
   public void Run ()
        {
            try
            {
                //create a server socket 
                IPAddress address = Dns.GetHostAddresses(Dns.GetHostName())[0];
                int port = 8000;
                TcpListener serverSocket = new TcpListener(address, port); 
                serverSocket.Start();
                Console.WriteLine("Server started on " + address + ":" + port);
                while (true)
                {
                    //accept incoming client connection
                    TcpClient clientSocket = serverSocket.AcceptTcpClient();
                    networkStream = clientSocket.GetStream();
                    Console.WriteLine("Client connected");
                    ////create a new thread for each client
                    //Task.Run(() => HandleClient(clientSocket));
                }

            }
        }
    }
}
