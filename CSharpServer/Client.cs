using Croissantbit;

namespace CSharpServer;

public class Client
{
    public Client()
    {
        var Ping = new Croissantbit.Ping();
        Console.WriteLine(Ping);
    }
}