using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;

namespace SKIT.FlurlHttpClient.Wechat
{
    /// <summary>
    /// SKIT.FlurlHttpClient.Wechat 客户端基类。
    /// </summary>
    public abstract class WechatClientBase : IWechatClient
    {
        /// <summary>
        /// 
        /// </summary>
        protected IFlurlClient ProxyFlurlClient { get; }

        /// <summary>
        /// 
        /// </summary>
        protected WechatClientBase()
        {
            ProxyFlurlClient = new FlurlClient();
            ProxyFlurlClient.Configure(settings =>
            {
                settings.JsonSerializer = new FlurlSystemTextJsonSerializer();
            });
        }

        /// <inheritdoc/>
        public void Configure(Action<WechatClientSettings> configure)
        {
            if (configure == null) throw new ArgumentNullException(nameof(configure));

            ProxyFlurlClient.Configure(flurlSettings =>
            {
                var settings = new WechatClientSettings();
                settings.Timeout = flurlSettings.Defaults.Timeout;
                settings.ConnectionLeaseTimeout = flurlSettings.ConnectionLeaseTimeout;
                settings.JsonSerializer = flurlSettings.Defaults.JsonSerializer;
                settings.UrlEncodedSerializer = flurlSettings.Defaults.UrlEncodedSerializer;
                settings.HttpClientFactory = flurlSettings.HttpClientFactory;
                configure.Invoke(settings);

                flurlSettings.Timeout = settings.Timeout;
                flurlSettings.ConnectionLeaseTimeout = settings.ConnectionLeaseTimeout;
                flurlSettings.JsonSerializer = settings.JsonSerializer;
                flurlSettings.UrlEncodedSerializer = settings.UrlEncodedSerializer;
                flurlSettings.HttpClientFactory = settings.HttpClientFactory;
            });
        }

        /// <inheritdoc/>
        public IFlurlRequest CreateRequest(params object[] urlSegments)
        {
            return CreateRequest(HttpMethod.Get, urlSegments);
        }

        /// <inheritdoc/>
        public IFlurlRequest CreateRequest(HttpMethod method, params object[] urlSegments)
        {
            return ProxyFlurlClient.Request(urlSegments).WithVerb(method);
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected virtual async Task<IFlurlResponse> SendRequestAsync(IFlurlRequest request, HttpContent? content = null, CancellationToken cancellationToken = default)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var response = await request
                .WithClient(ProxyFlurlClient)
                .AllowAnyHttpStatus()
                .SendAsync(request.Verb, content, cancellationToken)
                .ConfigureAwait(false);
            return response;
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected virtual async Task<IFlurlResponse> SendRequestWithJsonAsync(IFlurlRequest request, object? data = null, CancellationToken cancellationToken = default)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var response = await request
                .WithClient(ProxyFlurlClient)
                .AllowAnyHttpStatus()
                .SendJsonAsync(request.Verb, data, cancellationToken)
                .ConfigureAwait(false);
            return response;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public virtual void Dispose()
        {
            ProxyFlurlClient?.Dispose();
        }
    }
}
