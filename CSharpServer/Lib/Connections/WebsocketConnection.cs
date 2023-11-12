using vtortola.WebSockets;

namespace CSharpServer.Lib.Connections;

public class WebsocketConnection : Connection
{
    private WebSocket _socket;
    
    public WebsocketConnection()
    {
    }
    
    public override void SendRaw(byte[] message)
    {
        Console.WriteLine("Sending message");
        
    }
}