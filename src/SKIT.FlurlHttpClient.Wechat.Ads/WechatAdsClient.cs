using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl.Http.Configuration;

namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    /// <summary>
    /// 一个微信广告平台 API HTTP 客户端。
    /// </summary>
    public class WechatAdsClient : WechatClientBase
    {
        /// <summary>
        /// 获取当前客户端使用的微信广告平台服务商 ID。
        /// </summary>
        public string AgencyId { get; }

        /// <summary>
        /// 获取当前客户端使用的微信广告平台服务商 AppId。
        /// </summary>
        public string AgencyAppId { get; }

        /// <summary>
        /// 获取当前客户端使用的微信广告平台服务商 ApiKey。
        /// </summary>
        internal string AgencyApiKey { get; }

        /// <summary>
        /// 获取当前客户端使用的 JSON 序列化器。
        /// </summary>
        internal ISerializer JsonSerializer
        {
            get { return ProxyFlurlClient.Settings?.JsonSerializer ?? new FlurlNewtonsoftJsonSerializer(); }
        }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatAdsClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatAdsClient(WechatAdsClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            AgencyId = options.AgencyId;
            AgencyAppId = options.AgencyAppId;
            AgencyApiKey = options.AgencyApiKey;

            ProxyFlurlClient.BaseUrl = options.Endpoints ?? WechatAdsEndpoints.DEFAULT;
            ProxyFlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));

            var interceptorAuthenticator = new Interceptors.WechatAdsAuthenticator(
                agencyId: options.AgencyId,
                agencyApiKey: options.AgencyApiKey
            );
            ProxyFlurlClient.BeforeCall((call) => interceptorAuthenticator.Authenticate(call));
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
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestAsync<T>(IFlurlRequest request, HttpContent? content = null, CancellationToken cancellationToken = default)
            where T : WechatAdsResponse, new()
        {
            try
            {
                using IFlurlResponse response = await base.SendRequestAsync(request, content, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(response).ConfigureAwait(false);
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
        /// <param name="request"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestWithJsonAsync<T>(IFlurlRequest request, object? data = null, CancellationToken cancellationToken = default)
            where T : WechatAdsResponse, new()
        {
            try
            {
                using IFlurlResponse response = await base.SendRequestWithJsonAsync(request, data, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(response).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatAdsException(ex.Message, ex);
            }
        }

        private async Task<T> GetResposneAsync<T>(IFlurlResponse response)
            where T : WechatAdsResponse, new()
        {
            string contentType = response.Headers.GetAll("Content-Type").FirstOrDefault() ?? string.Empty;
            string contentDisposition = response.Headers.GetAll("Content-Disposition").FirstOrDefault() ?? string.Empty;
            bool contentTypeIsNotJson =
                (response.StatusCode != (int)HttpStatusCode.OK) ||
                (!contentType.StartsWith("application/json") && !contentType.StartsWith("text/json")) ||
                (contentDisposition.StartsWith("attachment"));

            T result = contentTypeIsNotJson ? new T() : await response.GetJsonAsync<T>().ConfigureAwait(false);
            result.RawStatus = response.StatusCode;
            result.RawHeaders = new ReadOnlyDictionary<string, string>(
                response.Headers
                    .GroupBy(e => e.Name)
                    .ToDictionary(
                        k => k.Key,
                        v => string.Join(", ", v.Select(e => e.Value))
                    )
            );
            result.RawBytes = await response.ResponseMessage.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            return result;
        }
    }
}
