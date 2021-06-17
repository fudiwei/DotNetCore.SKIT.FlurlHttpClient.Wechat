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
        public string WechatCorpId { get; }

        /// <summary>
        /// 获取当前客户端使用的企业微信应用的 AgentId。
        /// </summary>
        internal int? WechatAgentId { get; }

        /// <summary>
        /// 获取当前客户端使用的企业微信应用的 AgentSecret。
        /// </summary>
        internal string? WechatAgentSecret { get; }

        /// <summary>
        /// 获取当前客户端使用的企业微信服务商 Secret。
        /// </summary>
        internal string? WechatProviderSecret { get; set; }

        /// <summary>
        /// 获取当前客户端使用的企业微信第三方应用的 SuiteId。
        /// </summary>
        internal string? WechatSuiteId { get; set; }

        /// <summary>
        /// 获取当前客户端使用的企业微信第三方应用的 SuiteSecret。
        /// </summary>
        internal string? WechatSuiteSecret { get; set; }

        /// <summary>
        /// 获取当前客户端使用的 JSON 序列化器。
        /// </summary>
        internal ISerializer FlurlJsonSerializer
        {
            get { return FlurlClient.Settings?.JsonSerializer ?? new FlurlNewtonsoftJsonSerializer(); }
        }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="WechatWorkClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public WechatWorkClient(WechatWorkClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            WechatCorpId = options.CorpId;
            WechatAgentId = options.AgentId;
            WechatAgentSecret = options.AgentSecret;
            WechatProviderSecret = options.ProviderSecret;
            WechatSuiteId = options.SuiteId;
            WechatSuiteSecret = options.SuiteSecret;

            FlurlClient.BaseUrl = options.Endpoints ?? WechatWorkEndpoints.DEFAULT;
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));
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
        /// <param name="flurlRequest"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestAsync<T>(IFlurlRequest flurlRequest, HttpContent? content = null, CancellationToken cancellationToken = default)
            where T : WechatWorkResponse, new()
        {
            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, content, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(flurlResponse).ConfigureAwait(false);
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
        /// <param name="flurlRequest"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestWithJsonAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : WechatWorkResponse, new()
        {
            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestWithJsonAsync(flurlRequest, data, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(flurlResponse).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new WechatWorkException(ex.Message, ex);
            }
        }

        private async Task<T> GetResposneAsync<T>(IFlurlResponse flurlResponse)
            where T : WechatWorkResponse, new()
        {
            string contentType = flurlResponse.Headers.GetAll("Content-Type").FirstOrDefault() ?? string.Empty;
            string contentDisposition = flurlResponse.Headers.GetAll("Content-Disposition").FirstOrDefault() ?? string.Empty;
            bool contentTypeIsNotJson =
                (flurlResponse.StatusCode != (int)HttpStatusCode.OK) ||
                (!contentType.StartsWith("application/json") && !contentType.StartsWith("text/json") && !contentType.StartsWith("text/plain")) ||
                (contentDisposition.StartsWith("attachment"));

            T result = contentTypeIsNotJson ? new T() : await flurlResponse.GetJsonAsync<T>().ConfigureAwait(false);
            result.RawStatus = flurlResponse.StatusCode;
            result.RawHeaders = new ReadOnlyDictionary<string, string>(
                flurlResponse.Headers
                    .GroupBy(e => e.Name)
                    .ToDictionary(
                        k => k.Key,
                        v => string.Join(", ", v.Select(e => e.Value))
                    )
            );
            result.RawBytes = await flurlResponse.ResponseMessage.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            return result;
        }
    }
}
