using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    using SKIT.FlurlHttpClient.Internal;

    /// <summary>
    /// 一个微信支付 API HTTP 客户端。
    /// </summary>
    public partial class WechatTenpayClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的微信商户平台凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatTenpayClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatTenpayClient(WechatTenpayClientOptions options)
            : this(options, null)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <param name="httpClient"></param>
        /// <param name="disposeClient"></param>
        internal protected WechatTenpayClient(WechatTenpayClientOptions options, HttpClient? httpClient, bool disposeClient = true)
            : base(httpClient ?? new HttpClient(new Settings.WechatpayHttpHandler(options.MerchantCertificateBytes, options.MerchantCertificatePassword ?? options.MerchantId)), disposeClient)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoint ?? WechatTenpayEndpoints.DEFAULT;
            FlurlClient.WithTimeout(options.Timeout <= 0 ? Timeout.InfiniteTimeSpan : TimeSpan.FromMilliseconds(options.Timeout));
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="httpMethod"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateFlurlRequest(WechatTenpayRequest request, HttpMethod httpMethod, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = base.CreateFlurlRequest(request, httpMethod, urlSegments);

            if (request.MerchantId is null)
            {
                request.MerchantId = Credentials.MerchantId;
            }

            if (request.AppId is null)
            {
                request.AppId = Credentials.AppId;
            }

            if (request is WechatTenpaySignableRequest signableRequest)
            {
                if (signableRequest.NonceString is null)
                {
                    signableRequest.NonceString = Guid.NewGuid().ToString("N");
                }

                if (signableRequest.Signature is null)
                {
                    try
                    {
                        signableRequest.Signature = Utilities.RequestSigner.SignFromJson(
                            json: JsonSerializer.Serialize(signableRequest),
                            secret: Credentials.MerchantSecret,
                            signType: signableRequest.SignType
                        );
                    }
                    catch (Exception ex)
                    {
                        throw new WechatTenpayException("Failed to sign request. Please see the inner exception for more details.", ex);
                    }
                }
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
            where T : WechatTenpayResponse, new()
        {
            if (flurlRequest is null) throw new ArgumentNullException(nameof(flurlRequest));

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
        public async Task<T> SendFlurlRequestAsXmlAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : WechatTenpayResponse, new()
        {
            if (flurlRequest is null) throw new ArgumentNullException(nameof(flurlRequest));

            bool isSimpleRequest = data is null ||
                flurlRequest.Verb == HttpMethod.Get ||
                flurlRequest.Verb == HttpMethod.Head ||
                flurlRequest.Verb == HttpMethod.Options;
            if (isSimpleRequest)
            {
                using IFlurlResponse flurlResponse = await base.SendFlurlRequestAsync(flurlRequest, null, cancellationToken);
                return await WrapFlurlResponseAsXmlAsync<T>(flurlResponse, cancellationToken);
            }
            else
            {
                HttpContent httpContent;

                try
                {
                    string json = JsonSerializer.Serialize(data);
                    string xml = Utilities.XmlHelper.ConvertFromJson(json);

                    httpContent = new StringContent(xml, Encoding.UTF8, "application/xml");
                }
                catch (Exception ex)
                {
                    throw new CommonSerializationException(ex.Message, ex);
                }

                try
                {
                    using IFlurlResponse flurlResponse = await SendFlurlRequestAsync(flurlRequest, httpContent: httpContent, cancellationToken);
                    return await WrapFlurlResponseAsXmlAsync<T>(flurlResponse, cancellationToken);
                }
                catch (OperationCanceledException)
                {
                    throw;
                }
                catch (CommonException)
                {
                    throw;
                }
                catch (FlurlHttpException ex)
                {
                    throw new CommonHttpException(ex.Message, ex);
                }
                catch (Exception ex)
                {
                    throw new CommonException(ex.Message, ex);
                }
                finally
                {
                    httpContent.Dispose();
                }
            }
        }

        private async Task<TResponse> WrapFlurlResponseAsXmlAsync<TResponse>(IFlurlResponse flurlResponse, CancellationToken cancellationToken = default)
            where TResponse : WechatTenpayResponse, new()
        {
            var tmp = await WrapFlurlResponseAsync<TResponse>(flurlResponse, cancellationToken);
            var tmpBytes = tmp.GetRawBytes();

            var result = default(TResponse);
            if (_StringSyntaxAssert.MaybeXml(tmpBytes))
            {
                try
                {
                    string xml = Encoding.UTF8.GetString(tmpBytes);
                    string json = Utilities.XmlHelper.ConvertToJson(xml);

                    result = JsonSerializer.Deserialize<TResponse>(json);
                }
                catch (Exception ex)
                {
                    throw new CommonSerializationException(ex.Message, ex);
                }

                var accessor = _UnsafeAccessor.VisitCommonResponse<TResponse>(result);
                accessor.RawStatus = tmp.GetRawStatus();
                accessor.RawHeaders = tmp.GetRawHeaders();
                accessor.RawBytes = tmpBytes;
            }
            else
            {
                result = tmp;
            }

            return result;
        }
    }
}
