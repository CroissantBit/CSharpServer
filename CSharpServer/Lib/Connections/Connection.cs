namespace CSharpServer.Lib.Connections;

// Abstract class for connection
// Handles websockets and serial connections
public abstract class Connection
{
    public Connection()
    {
    }
    
    public abstract void SendRaw(byte[] message);
}