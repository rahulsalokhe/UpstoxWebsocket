//#RahulSalokhe
//RahulSalokhe@gmail.com

using Newtonsoft.Json;
using System.Net;
using System.Security.Authentication;
using System.Text;

namespace UpstoxWebsocket;

internal class Program
{

    public static string AccessToken = "ACCESS_TOKEN";
    public static string MessageSend = "";
    static void Main(string[] args)
    {
        try
        {


            string Mode_ = "ltpc";

            Mode_ = "ltpc";
            //Mode_ = "full";

            var data2 = new
            {
                guid = "someguid",
                method = "sub",
                data = new
                {
                    mode = Mode_,
                    instrumentKeys = "NSE_INDEX|Nifty Bank,NSE_INDEX|Nifty 50".Split(',')
                }
            };

            MessageSend = JsonConvert.SerializeObject(data2);

            string URL = GetURLAsync().Result;


            using (WebSocketSharp.WebSocket ws = new WebSocketSharp.WebSocket(URL))
            {
                ws.OnOpen += async (sender, e) =>
                {
                    Console.WriteLine("Open");
                    await Task.Delay(TimeSpan.FromSeconds(1));

                    byte[] bytes = Encoding.UTF8.GetBytes(MessageSend);
                    ws.Send(bytes);

                    Console.WriteLine(MessageSend);



                };
                ws.OnClose += Ws_OnClose;
                ws.OnError += Ws_OnError;
                ws.OnMessage += Ws_OnMessage;
                ws.Connect();


                Thread.Sleep(TimeSpan.FromSeconds(1));


                Console.ReadKey();
            }



        }
        catch (Exception e)
        {
            Console.WriteLine("Exception : " + e.Message);
        }

    }

    private static void Ws_OnMessage(object? sender, WebSocketSharp.MessageEventArgs e)
    {
        if (e.IsPing)
        {


        }

        if (e.IsText)
        {

        }
        if (e.IsBinary)
        {
            StringBuilder strB = new StringBuilder();

            var RObj = FeedResponse.Parser.ParseFrom(e.RawData);

            foreach (var item in RObj.Feeds)
            {
                string NameOfS = item.Key;

                strB.Append($"{NameOfS}: ");

                var typeObj = item.Value.FeedUnionCase;

                switch (typeObj)
                {
                    case Feed.FeedUnionOneofCase.None:
                        break;
                    case Feed.FeedUnionOneofCase.Ltpc:
                        LTPC L1 = item.Value.Ltpc;
                        strB.Append($"Ltp:{L1.Ltp},Ltq:{L1.Ltq},Ltq:{L1.Ltt},Cp:{L1.Cp} ");
                        break;
                    case Feed.FeedUnionOneofCase.Ff:
                        MarketFullFeed o2 = item.Value.Ff.MarketFF;

                        break;
                    case Feed.FeedUnionOneofCase.Oc:
                        OptionChain o3 = item.Value.Oc;
                        OptionGreeks ss = o3.OptionGreeks;
                        break;

                }







            }

            Console.WriteLine(strB.ToString());
        }


    }

    private static void Ws_OnError(object? sender, WebSocketSharp.ErrorEventArgs e)
    {
        Console.WriteLine("Ws_OnError");
    }

    private static void Ws_OnClose(object? sender, WebSocketSharp.CloseEventArgs e)
    {
        Console.WriteLine("Ws_OnClose");
    }



    private static async Task<string> GetURLAsync()
    {
        string url = "";


        HttpClient httpClient = new HttpClient();
        string response = "";
        string APIurl = "https://api.upstox.com/v2/feed/market-data-feed/authorize";

        const SslProtocols _Tls12 = (SslProtocols)0x00000C00;
        const SecurityProtocolType Tls12 = (SecurityProtocolType)_Tls12;
        ServicePointManager.SecurityProtocol = Tls12;



        string AuthToken = $"Bearer {AccessToken}";
        var sssd = httpClient.DefaultRequestHeaders.FirstOrDefault(x => x.Key == "Authorization");

        if (sssd.Value is not null)
        {
            if (string.IsNullOrWhiteSpace(sssd.Value.FirstOrDefault(x => x == AuthToken)))
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", AuthToken);
                httpClient.DefaultRequestHeaders.Add("Api-Version", "2.0");
            }
        }
        else
        {
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", AuthToken);
            httpClient.DefaultRequestHeaders.Add("Api-Version", "2.0");
        }


        response = await httpClient.GetStringAsync(APIurl);

        var OutRes = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response);

        url = OutRes["data"]["authorized_redirect_uri"];


        return url;

    }

}
