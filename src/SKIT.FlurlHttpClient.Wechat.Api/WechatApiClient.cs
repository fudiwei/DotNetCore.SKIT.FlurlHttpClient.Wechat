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

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 一个微信 API HTTP 客户端。
    /// </summary>
    public class WechatApiClient : WechatClientBase
    {
        /// <summary>
        /// 获取当前客户端使用的微信 AppId。
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// 获取当前客户端使用的微信 AppSecret。
        /// </summary>
        internal string AppSecret { get; }

        /// <summary>
        /// 获取当前客户端使用的即时配送公司帐号 AppKey（用于即使配送相关接口的请求签名）。
        /// </summary>
        internal string? ImmeDeliveryAppKey { get; }

        /// <summary>
        /// 获取当前客户端使用的即时配送公司帐号 AppSecret（用于即使配送相关接口的请求签名）。
        /// </summary>
        internal string? ImmeDeliveryAppSecret { get; }

        /// <summary>
        /// 获取或设置米大师平台 AppKey（用于虚拟支付相关接口的请求签名）。
        /// </summary>
        internal string? MidasAppKey { get; }

        /// <summary>
        /// 获取当前客户端使用的 JSON 序列化器。
        /// </summary>
        internal ISerializer JsonSerializer
        {
            get { return ProxyFlurlClient.Settings?.JsonSerializer ?? new FlurlNewtonsoftJsonSerializer(); }
        }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatApiClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatApiClient(WechatApiClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            AppId = options.AppId;
            AppSecret = options.AppSecret;
            ImmeDeliveryAppKey = options.ImmeDeliveryAppKey;
            ImmeDeliveryAppSecret = options.ImmeDeliveryAppSecret;
            MidasAppKey = options.MidasAppKey;

            ProxyFlurlClient.BaseUrl = options.Endpoints ?? WechatApiEndpoints.DEFAULT;
            ProxyFlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));
        }

        /// <summary>
        /// 用指定的微信 AppId 和微信 AppSecret 初始化 <see cref="WechatApiClient"/> 类的新实例。
        /// </summary>
        /// <param name="appId">微信 AppId。</param>
        /// <param name="appSecret">微信 AppSecret。</param>
        public WechatApiClient(string appId, string appSecret)
            : this(new WechatApiClientOptions() { AppId = appId, AppSecret = appSecret })
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
            where T : WechatApiResponse, new()
        {
            try
            {
                using IFlurlResponse response = await base.SendRequestAsync(request, content, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(response).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatApiException(ex.Message, ex);
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
            where T : WechatApiResponse, new()
        {
            try
            {
                using IFlurlResponse response = await base.SendRequestWithJsonAsync(request, data, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(response).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatApiException(ex.Message, ex);
            }
        }

        private async Task<T> GetResposneAsync<T>(IFlurlResponse response)
            where T : WechatApiResponse, new()
        {
            string contentType = response.Headers.GetAll("Content-Type").FirstOrDefault() ?? string.Empty;
            bool contentTypeIsNotJson =
                (response.StatusCode != (int)HttpStatusCode.OK) ||
                (!contentType.StartsWith("application/json") && !contentType.StartsWith("text/json") && !contentType.StartsWith("text/plain"));

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
