using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectionHandler connectionHandler = new ConnectionHandler();
            PetRepository petRepository = new PetRepository();
            //connectionHandler.Run();
        }
    }
}
