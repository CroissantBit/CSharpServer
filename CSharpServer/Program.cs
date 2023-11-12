using System.Net;
using CSharpServer.lib;

namespace CSharpServer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //new Client();
        new WebsocketServer(IPEndPoint.Parse("127.0.0.1:8080"));
    }
}