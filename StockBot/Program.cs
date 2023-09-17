// See https://aka.ms/new-console-template for more information
using Alpaca.Markets;
using System.Net.WebSockets;

Console.WriteLine("Hello, World!");




void MinuteBarSub_Received(IBar obj)
{
    Console.WriteLine(obj.ToString());
}

void Client_SocketOpened()
{
    Console.WriteLine("Socket connected");
}

void Client_SocketClosed()
{
    Console.WriteLine("Socket closed");
}


using (var client = Environments.Live.GetAlpacaDataStreamingClient(new SecretKey(key, secret)))
{

    client.SocketOpened += Client_SocketOpened;
    client.SocketClosed += Client_SocketClosed;

    await client.ConnectAndAuthenticateAsync();

    var minuteBarSub = client.GetMinuteBarSubscription("AAPL");


    await client.SubscribeAsync(minuteBarSub);


    while (true)
    {
        Thread.Sleep(1000);
    }
}



const string authMessage = $"{{ \"action\": \"auth\", \"key\": \"{key}\", \"secret\": \"{secret}\" }}";
const string baseUrl = "wss://stream.data.sandbox.alpaca.markets/v2/sip";

