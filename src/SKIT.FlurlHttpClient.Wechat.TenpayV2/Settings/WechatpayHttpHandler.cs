using System;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Settings
{
    public sealed class WechatpayHttpHandler : DelegatingHandler
    {
        public WechatpayHttpHandler(byte[]? certificateBytes, string? certificatePassword)
        {
#if NETCOREAPP2_1_OR_GREATER || NET5_0_OR_GREATER
            SocketsHttpHandler handler = new SocketsHttpHandler();
            handler.SslOptions = new SslClientAuthenticationOptions() { RemoteCertificateValidationCallback = static (_, _, _, _) => true };
#else
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = static (_, _, _, sslPolicyErrors) => sslPolicyErrors == SslPolicyErrors.None;
#endif

            if (certificateBytes is not null)
            {
                X509Certificate x509;

#if NET471_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NET5_0_OR_GREATER
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
#else
                if (Environment.OSVersion.Platform == PlatformID.Win32NT)
#endif
                {
                    x509 = (certificatePassword is null)
                        ? new X509Certificate2(certificateBytes)
                        : new X509Certificate2(certificateBytes, certificatePassword, X509KeyStorageFlags.MachineKeySet);
                }
                else
                {
                    x509 = (certificatePassword is null)
                        ? new X509Certificate2(certificateBytes)
                        : new X509Certificate2(certificateBytes, certificatePassword, X509KeyStorageFlags.UserKeySet | X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet);
                }

#if NETCOREAPP2_1_OR_GREATER || NET5_0_OR_GREATER
                handler.SslOptions.ClientCertificates = new X509CertificateCollection() { x509 };   
#else
                handler.ClientCertificates.Add(x509);
#endif
            }

            InnerHandler = handler;
        }
    }
}
