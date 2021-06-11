using System;
using System.Security.Authentication;
using Leaf.xNet;

namespace DiscordAIO
{
    public static class Client
    {
        public static HttpRequest Create(bool usingProxy, string proxy, string proxyType, string timeout, string token)
        {
            HttpRequest result = new HttpRequest();
            result.AddHeader("authorization", token);
            result.UserAgentRandomize();
            result.SslProtocols = SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12;

            if (usingProxy)
            {
                ProxyType proxyType1;

                switch (proxyType)
                {
                    case "HTTP":
                        proxyType1 = ProxyType.HTTP;
                        break;
                    case "SOCKS4":
                        proxyType1 = ProxyType.Socks4;
                        break;
                    case "SOCKS4a":
                        proxyType1 = ProxyType.Socks4A;
                        break;
                    case "SOCKS5":
                        proxyType1 = ProxyType.Socks5;
                        break;
                    default:
                        proxyType1 = ProxyType.HTTP;
                        break;
                }

                result.Proxy = ProxyClient.Parse(proxyType1,
                    proxy);
                result.Proxy.ReadWriteTimeout = Convert.ToInt32(timeout);
                result.Proxy.ConnectTimeout = Convert.ToInt32(timeout);
            }

            return result;
        }
    }
}
