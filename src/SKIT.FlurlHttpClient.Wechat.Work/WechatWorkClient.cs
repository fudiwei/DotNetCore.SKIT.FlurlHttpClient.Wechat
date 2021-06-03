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

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 一个企业微信 API HTTP 客户端。
    /// </summary>
    public class WechatWorkClient : WechatClientBase
    {
        /// <summary>
        /// 获取当前客户端使用的企业微信 CorpId。
        /// </summary>
        public string CorpId { get; }

        /// <summary>
        /// 获取当前客户端使用的企业微信应用的 AgentId。
        /// </summary>
        internal int? AgentId { get; }

        /// <summary>
        /// 获取当前客户端使用的企业微信应用的 AgentSecret。
        /// </summary>
        internal string? AgentSecret { get; }

        /// <summary>
        /// 获取当前客户端使用的企业微信服务商 Secret。
        /// </summary>
        internal string? ProviderSecret { get; set; }

        /// <summary>
        /// 获取当前客户端使用的企业微信第三方应用的 SuiteId。
        /// </summary>
        internal string? SuiteId { get; set; }

        /// <summary>
        /// 获取当前客户端使用的企业微信第三方应用的 SuiteSecret。
        /// </summary>
        internal string? SuiteSecret { get; set; }

        /// <summary>
        /// 获取当前客户端使用的 JSON 序列化器。
        /// </summary>
        internal ISerializer JsonSerializer
        {
            get { return ProxyFlurlClient.Settings?.JsonSerializer ?? new FlurlNewtonsoftJsonSerializer(); }
        }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatWorkClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatWorkClient(WechatWorkClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            CorpId = options.CorpId;
            AgentId = options.AgentId;
            AgentSecret = options.AgentSecret;
            ProviderSecret = options.ProviderSecret;
            SuiteId = options.SuiteId;
            SuiteSecret = options.SuiteSecret;

            ProxyFlurlClient.BaseUrl = options.Endpoints ?? WechatWorkEndpoints.DEFAULT;
            ProxyFlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));
        }

        /// <summary>
        /// 用指定的企业微信 CorpId、企业微信 AgentId 和企业微信 AgentSecret 初始化 <see cref="WechatWorkClient"/> 类的新实例。
        /// </summary>
        /// <param name="corpId">企业微信 CorpId。</param>
        /// <param name="agentId">企业微信 AgentId。</param>
        /// <param name="agentSecret">企业微信 AgentSecret。</param>
        public WechatWorkClient(string corpId, int agentId, string agentSecret)
            : this(new WechatWorkClientOptions() { CorpId = corpId, AgentId = agentId, AgentSecret = agentSecret })
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
            where T : WechatWorkResponse, new()
        {
            try
            {
                using IFlurlResponse response = await base.SendRequestAsync(request, content, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(response).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatWorkException(ex.Message, ex);
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
            where T : WechatWorkResponse, new()
        {
            try
            {
                using IFlurlResponse response = await base.SendRequestWithJsonAsync(request, data, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(response).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatWorkException(ex.Message, ex);
            }
        }

        private async Task<T> GetResposneAsync<T>(IFlurlResponse response)
            where T : WechatWorkResponse, new()
        {
            string contentType = response.Headers.GetAll("Content-Type").FirstOrDefault() ?? string.Empty;
            string contentDisposition = response.Headers.GetAll("Content-Disposition").FirstOrDefault() ?? string.Empty;
            bool contentTypeIsNotJson =
                (response.StatusCode != (int)HttpStatusCode.OK) ||
                (!contentType.StartsWith("application/json") && !contentType.StartsWith("text/json") && !contentType.StartsWith("text/plain")) ||
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
