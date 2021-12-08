using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    /// <summary>
    /// 一个微信广告平台 API HTTP 客户端。
    /// </summary>
    public class WechatAdsClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的微信广告平台凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatAdsClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatAdsClient(WechatAdsClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoints ?? WechatAdsEndpoints.DEFAULT;
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));

            Interceptors.Add(new Interceptors.WechatAdsAgencyTokenInterceptor(
                agencyId: options.AgencyId,
                agencyApiKey: options.AgencyApiKey
            ));
        }

        /// <summary>
        /// 用指定的微信广告平台服务商 ID、微信广告平台服务商 AppId、微信广告平台服务商 ApiKey 初始化 <see cref="WechatAdsClient"/> 类的新实例。
        /// </summary>
        /// <param name="agencyId">微信广告平台服务商 ID。</param>
        /// <param name="agencyAppId">微信广告平台服务商 AppId。</param>
        /// <param name="agencyApiKey">微信广告平台服务商 ApiKey。</param>
        public WechatAdsClient(string agencyId, string agencyAppId, string agencyApiKey)
            : this(new WechatAdsClientOptions() { AgencyId = agencyId, AgencyAppId = agencyAppId, AgencyApiKey = agencyApiKey })
        {
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateRequest(WechatAdsRequest request, HttpMethod method, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = FlurlClient.Request(urlSegments).WithVerb(method);

            if (request.Timeout != null)
            {
                flurlRequest.WithTimeout(TimeSpan.FromMilliseconds(request.Timeout.Value));
            }

            if (request.Version != null)
            {
                flurlRequest.SetQueryParam("version", request.Version);
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
            where T : WechatAdsResponse, new()
        {
            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(flurlResponse).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatAdsException(ex.Message, ex);
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
            where T : WechatAdsResponse, new()
        {
            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestWithJsonAsync(flurlRequest, data, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(flurlResponse).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatAdsException(ex.Message, ex);
            }
        }

        private async Task<T> GetResposneAsync<T>(IFlurlResponse flurlResponse)
            where T : WechatAdsResponse, new()
        {
            byte[] bytes = await flurlResponse.GetBytesAsync().ConfigureAwait(false);
            bool jsonable = bytes.Length > 1 &&
                (bytes[0] == 91 && bytes[bytes.Length - 1] == 93) || // "[...]"
                (bytes[0] == 123 && bytes[bytes.Length - 1] == 125); // "{...}"

            T result = jsonable ? JsonSerializer.Deserialize<T>(Encoding.UTF8.GetString(bytes)) : new T();

            result.RawStatus = flurlResponse.StatusCode;
            result.RawHeaders = new ReadOnlyDictionary<string, string>(
                flurlResponse.Headers
                    .GroupBy(e => e.Name)
                    .ToDictionary(
                        k => k.Key,
                        v => string.Join(", ", v.Select(e => e.Value))
                    )
            );
            result.RawBytes = bytes;

            return result;
        }
    }
}
