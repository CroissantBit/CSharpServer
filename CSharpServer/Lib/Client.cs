using CSharpServer.Lib.Connections;
using Google.Protobuf;


namespace CSharpServer.lib;

public class Client
{
    private Connection connection;

    public Client()
    {
        var ping = new Croissantbit.Ping();
        Console.WriteLine(ping);
    }

    public void SendPrefixed(IMessage message)
    {
        var msgId = MessageId.GetMessageId(message);
        var msgBytes = message.ToByteArray();

        // Prefix the msgBytes with the msgId
        var msgIdBytes = BitConverter.GetBytes(msgId);
        var prefixedMsgBytes = new byte[msgIdBytes.Length + msgBytes.Length];
        msgIdBytes.CopyTo(prefixedMsgBytes, 0);
        msgBytes.CopyTo(prefixedMsgBytes, msgIdBytes.Length);

        // Send the prefixed message
        connection.SendRaw(prefixedMsgBytes);
    }
}