using System;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Settings
{
    public class HttpClientFactory : Flurl.Http.Configuration.DefaultHttpClientFactory
    {
        private readonly byte[]? _certBytes;
        private readonly string? _certPassword;

        public HttpClientFactory(byte[]? certBytes, string? certPassword)
        {
            _certBytes = certBytes;
            _certPassword = certPassword;
        }

        public override HttpMessageHandler CreateMessageHandler()
        {
#if NETFRAMEWORK
            WebRequestHandler handler = new WebRequestHandler();
            handler.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => sslPolicyErrors == SslPolicyErrors.None;
#else
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (requestMessage, certificate, chain, sslPolicyErrors) => sslPolicyErrors == SslPolicyErrors.None;
#endif

            if (_certBytes != null)
            {
                X509Certificate x509 = (_certPassword == null) ? new X509Certificate2(_certBytes) : new X509Certificate2(_certBytes, _certPassword);
                handler.ClientCertificates.Add(x509);
            }

            return handler;
        }
    }
}
