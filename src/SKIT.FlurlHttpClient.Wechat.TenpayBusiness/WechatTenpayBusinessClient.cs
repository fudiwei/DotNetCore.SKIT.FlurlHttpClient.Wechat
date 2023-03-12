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
    /// 一个腾讯微企付 API HTTP 客户端。
    /// </summary>
    public class WechatTenpayBusinessClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的腾讯微企付平台凭证。
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
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);
            AutoEncryptRequestSensitiveProperty = options.AutoEncryptRequestSensitiveProperty;
            AutoDecryptResponseSensitiveProperty = options.AutoDecryptResponseSensitiveProperty;

            FlurlClient.BaseUrl = options.Endpoint ?? WechatTenpayBusinessEndpoints.DEFAULT;
            FlurlClient.Headers.Remove(FlurlHttpClient.Constants.HttpHeaders.Accept);
            FlurlClient.Headers.Remove(FlurlHttpClient.Constants.HttpHeaders.AcceptLanguage);
            FlurlClient.WithHeader(FlurlHttpClient.Constants.HttpHeaders.Accept, "application/json");
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));

            Interceptors.Add(new Interceptors.WechatTenpayBusinessRequestSignatureInterceptor(
                signAlg: options.SignAlgorithm,
                platformId: options.PlatformId,
                platformCertSn: options.PlatformCertificateSerialNumber,
                platformCertPk: options.PlatformCertificatePrivateKey
            ));
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateRequest(WechatTenpayBusinessRequest request, HttpMethod method, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = FlurlClient.Request(urlSegments).WithVerb(method);

            if (AutoEncryptRequestSensitiveProperty)
            {
                this.EncryptRequestSensitiveProperty(request);
            }

            if (request.Timeout != null)
            {
                flurlRequest.WithTimeout(TimeSpan.FromMilliseconds(request.Timeout.Value));
            }

            if (request.TBEPEncryption != null)
            {
                flurlRequest.Headers.Remove("TBEP-Encrypt");
                flurlRequest.WithHeader("TBEP-Encrypt", $"enc_key=\"{request.TBEPEncryption.EncryptedKey}\",iv=\"{Convert.ToBase64String(Encoding.UTF8.GetBytes(request.TBEPEncryption.IV))}\",tbep_serial_number=\"{request.TBEPEncryption.CertificateSerialNumber}\",algorithm=\"{request.TBEPEncryption.Algorithm}\"");
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
        public async Task<T> SendRequestAsync<T>(IFlurlRequest flurlRequest, HttpContent? httpContent = null, CancellationToken cancellationToken = default)
            where T : WechatTenpayBusinessResponse, new()
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            if (httpContent != null)
            {
                if (string.IsNullOrEmpty(httpContent.Headers.ContentType?.MediaType))
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }

            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken);
            }
            catch (FlurlHttpTimeoutException ex)
            {
                throw new Exceptions.WechatTenpayBusinessRequestTimeoutException(ex.Message, ex);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatTenpayBusinessException(ex.Message, ex);
            }
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestWithJsonAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : WechatTenpayBusinessResponse, new()
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            try
            {
                bool isSimpleRequest = data == null ||
                    flurlRequest.Verb == HttpMethod.Get ||
                    flurlRequest.Verb == HttpMethod.Head ||
                    flurlRequest.Verb == HttpMethod.Options;
                using IFlurlResponse flurlResponse = isSimpleRequest ?
                    await base.SendRequestAsync(flurlRequest, null, cancellationToken) :
                    await base.SendRequestWithJsonAsync(flurlRequest, data, cancellationToken);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken);
            }
            catch (FlurlHttpTimeoutException ex)
            {
                throw new Exceptions.WechatTenpayBusinessRequestTimeoutException(ex.Message, ex);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatTenpayBusinessException(ex.Message, ex);
            }
        }

        private new async Task<TResponse> WrapResponseWithJsonAsync<TResponse>(IFlurlResponse flurlResponse, CancellationToken cancellationToken = default)
            where TResponse : WechatTenpayBusinessResponse, new()
        {
            TResponse result = await base.WrapResponseWithJsonAsync<TResponse>(flurlResponse, cancellationToken);

            string? strTBEPEncryption = flurlResponse.Headers.FirstOrDefault("TBEP-Encrypt");
            if (!string.IsNullOrEmpty(strTBEPEncryption))
            {
                IDictionary<string, string?> dictTBEPEncryption = strTBEPEncryption
                    .Split(',')
                    .Select(s => s.Trim().Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries))
                    .ToDictionary(
                        k => k[0],
                        v => v.Length > 1 ? v[1].TrimStart('\"').TrimEnd('\"') : null
                    );
                result.TBEPEncryption = new WechatTenpayBusinessResponseTBEPEncryption();
                result.TBEPEncryption.PlatformId = dictTBEPEncryption["platform_id"];
                result.TBEPEncryption.EncryptedKey = dictTBEPEncryption["enc_key"];
                result.TBEPEncryption.IV = dictTBEPEncryption["iv"];
                result.TBEPEncryption.CertificateSerialNumber = dictTBEPEncryption["platform_serial_number"];
                result.TBEPEncryption.Algorithm = dictTBEPEncryption["algorithm"];

                if (AutoDecryptResponseSensitiveProperty && result.IsSuccessful())
                {
                    this.DecryptResponseSensitiveProperty(result);
                }
            }

            return result;
        }
    }
}
