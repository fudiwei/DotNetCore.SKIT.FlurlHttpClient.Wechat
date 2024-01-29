using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    /// <summary>
    /// 一个微企付 API HTTP 客户端。
    /// </summary>
    public class WechatTenpayBusinessClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的微企付平台凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 获取是否自动加密请求中的敏感信息字段。
        /// </summary>
        protected bool AutoEncryptRequestSensitiveProperty { get; }

        /// <summary>
        /// 获取是否自动解密请求中的敏感信息字段。
        /// </summary>
        protected bool AutoDecryptResponseSensitiveProperty { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatTenpayBusinessClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatTenpayBusinessClient(WechatTenpayBusinessClientOptions options)
            : this(options, null)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <param name="httpClient"></param>
        /// <param name="disposeClient"></param>
        internal protected WechatTenpayBusinessClient(WechatTenpayBusinessClientOptions options, HttpClient? httpClient, bool disposeClient = true)
            : base(httpClient, disposeClient)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);
            AutoEncryptRequestSensitiveProperty = options.AutoEncryptRequestSensitiveProperty;
            AutoDecryptResponseSensitiveProperty = options.AutoDecryptResponseSensitiveProperty;

            FlurlClient.BaseUrl = options.Endpoint ?? WechatTenpayBusinessEndpoints.DEFAULT;
            FlurlClient.Headers.Remove(HttpHeaders.Accept);
            FlurlClient.Headers.Remove(HttpHeaders.AcceptLanguage);
            FlurlClient.WithHeader(HttpHeaders.Accept, "application/json");
            FlurlClient.WithTimeout(options.Timeout <= 0 ? Timeout.InfiniteTimeSpan : TimeSpan.FromMilliseconds(options.Timeout));

            Interceptors.Add(new Interceptors.WechatTenpayBusinessRequestSigningInterceptor(
                signAlg: options.SignAlgorithm,
                platformId: options.PlatformId,
                platformCertSn: options.PlatformCertificateSerialNumber,
                platformCertPk: options.PlatformCertificatePrivateKey,
                enterpriseId: options.EnterpriseId,
                enterpriseCertSn: options.EnterpriseCertificateSerialNumber,
                enterpriseCertPk: options.EnterpriseCertificatePrivateKey
            ));
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="httpMethod"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateFlurlRequest(WechatTenpayBusinessRequest request, HttpMethod httpMethod, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = base.CreateFlurlRequest(request, httpMethod, urlSegments);

            if (AutoEncryptRequestSensitiveProperty)
            {
                this.EncryptRequestSensitiveProperty(request);
            }

            if (request.WechatpayEncryption is not null)
            {
                flurlRequest.Headers.Remove("TBEP-Encrypt");
                flurlRequest.WithHeader("TBEP-Encrypt", $"enc_key=\"{request.WechatpayEncryption.EncryptedKey}\",iv=\"{Convert.ToBase64String(Encoding.UTF8.GetBytes(request.WechatpayEncryption.IV))}\",tbep_serial_number=\"{request.WechatpayEncryption.SerialNumber}\",algorithm=\"{request.WechatpayEncryption.Algorithm}\"");
            }

            return flurlRequest;
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="httpContent"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendFlurlRequestAsync<T>(IFlurlRequest flurlRequest, HttpContent? httpContent = null, CancellationToken cancellationToken = default)
            where T : WechatTenpayBusinessResponse, new()
        {
            if (flurlRequest is null) throw new ArgumentNullException(nameof(flurlRequest));

            if (httpContent is not null)
            {
                if (string.IsNullOrEmpty(httpContent.Headers.ContentType?.MediaType))
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }

            using IFlurlResponse flurlResponse = await base.SendFlurlRequestAsync(flurlRequest, httpContent, cancellationToken);
            return await WrapFlurlResponseAsJsonAsync<T>(flurlResponse, cancellationToken);
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendFlurlRequestAsJsonAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : WechatTenpayBusinessResponse, new()
        {
            if (flurlRequest is null) throw new ArgumentNullException(nameof(flurlRequest));

            bool isSimpleRequest = data is null ||
                flurlRequest.Verb == HttpMethod.Get ||
                flurlRequest.Verb == HttpMethod.Head ||
                flurlRequest.Verb == HttpMethod.Options;
            using IFlurlResponse flurlResponse = isSimpleRequest ?
                await base.SendFlurlRequestAsync(flurlRequest, null, cancellationToken) :
                await base.SendFlurlRequestAsJsonAsync(flurlRequest, data, cancellationToken);
            return await WrapFlurlResponseAsJsonAsync<T>(flurlResponse, cancellationToken);
        }

        private new async Task<TResponse> WrapFlurlResponseAsJsonAsync<TResponse>(IFlurlResponse flurlResponse, CancellationToken cancellationToken = default)
            where TResponse : WechatTenpayBusinessResponse, new()
        {
            TResponse result = await base.WrapFlurlResponseAsJsonAsync<TResponse>(flurlResponse, cancellationToken);

            string? strEncryption = flurlResponse.Headers.FirstOrDefault("TBEP-Encrypt");
            if (!string.IsNullOrEmpty(strEncryption))
            {
                IDictionary<string, string?> dictEncryption = strEncryption
                    .Split(',')
                    .Select(s => s.Trim().Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries))
                    .ToDictionary(
                        k => k[0],
                        v => v.Length > 1 ? v[1].TrimStart('\"').TrimEnd('\"') : null
                    );
                result.WechatpayEncryption = new WechatTenpayBusinessResponseEncryption();
                result.WechatpayEncryption.PlatformId = dictEncryption.GetValueOrDefault("platform_id");
                result.WechatpayEncryption.EnterpriseId = dictEncryption.GetValueOrDefault("ent_id");
                result.WechatpayEncryption.EncryptedKey = dictEncryption.GetValueOrDefault("enc_key");
                result.WechatpayEncryption.IV = dictEncryption.GetValueOrDefault("iv");
                result.WechatpayEncryption.SerialNumber = dictEncryption.GetValueOrDefault("platform_serial_number") ?? dictEncryption.GetValueOrDefault("enterprise_serial_number");
                result.WechatpayEncryption.Algorithm = dictEncryption.GetValueOrDefault("algorithm");

                if (AutoDecryptResponseSensitiveProperty && result.IsSuccessful())
                {
                    this.DecryptResponseSensitiveProperty(result);
                }
            }

            return result;
        }
    }
}
