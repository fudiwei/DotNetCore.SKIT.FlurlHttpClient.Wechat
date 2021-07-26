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
        /// <inheritdoc />
        /// </summary>
        public WechatHttpCallInterceptorCollection Interceptors { get; }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public ISerializer JsonSerializer
        {
            get { return FlurlClient.Settings?.JsonSerializer ?? FlurlHttp.GlobalSettings.JsonSerializer; }
        }

        /// <summary>
        /// 获取当前客户端使用的 <see cref="IFlurlClient"/> 对象。
        /// </summary>
        protected IFlurlClient FlurlClient { get; }

        /// <summary>
        /// 
        /// </summary>
        protected WechatClientBase()
        {
            Interceptors = new WechatHttpCallInterceptorCollection();
            FlurlClient = new FlurlClient();
            FlurlClient.Configure(flurlSettings =>
            {
                flurlSettings.JsonSerializer = new FlurlSystemTextJsonSerializer();
                flurlSettings.BeforeCallAsync = async (flurlCall) =>
                {
                    for (int i = 0, len = Interceptors.Count; i < len; i++)
                    {
                        await Interceptors[i].BeforeCallAsync(flurlCall);
                    }
                };
                flurlSettings.AfterCallAsync = async (flurlCall) =>
                {
                    for (int i = Interceptors.Count - 1; i >= 0; i--)
                    {
                        await Interceptors[i].AfterCallAsync(flurlCall);
                    }
                };
            });
        }

        /// <inheritdoc/>
        public void Configure(Action<WechatClientSettings> configure)
        {
            if (configure == null) throw new ArgumentNullException(nameof(configure));
            
            FlurlClient.Configure(flurlSettings =>
            {
                var settings = new WechatClientSettings();
                settings.Timeout = flurlSettings.Timeout;
                settings.ConnectionLeaseTimeout = flurlSettings.ConnectionLeaseTimeout;
                settings.JsonSerializer = flurlSettings.JsonSerializer;
                settings.UrlEncodedSerializer = flurlSettings.UrlEncodedSerializer;
                settings.FlurlHttpClientFactory = flurlSettings.HttpClientFactory;
                configure.Invoke(settings);

                flurlSettings.Timeout = settings.Timeout;
                flurlSettings.ConnectionLeaseTimeout = settings.ConnectionLeaseTimeout;
                flurlSettings.JsonSerializer = settings.JsonSerializer;
                flurlSettings.UrlEncodedSerializer = settings.UrlEncodedSerializer;
                flurlSettings.HttpClientFactory = settings.FlurlHttpClientFactory;
            });
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <param name="flurlRequest"></param>
        /// <param name="httpContent"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected virtual async Task<IFlurlResponse> SendRequestAsync(IFlurlRequest flurlRequest, HttpContent? httpContent = null, CancellationToken cancellationToken = default)
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            var response = await flurlRequest
                .WithClient(FlurlClient)
                .AllowAnyHttpStatus()
                .SendAsync(flurlRequest.Verb, httpContent, cancellationToken)
                .ConfigureAwait(false);
            return response;
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <param name="flurlRequest"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected virtual async Task<IFlurlResponse> SendRequestWithJsonAsync(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            if (flurlRequest.Verb == HttpMethod.Get)
            {
                return await flurlRequest
                    .WithClient(FlurlClient)
                    .AllowAnyHttpStatus()
                    .SendAsync(flurlRequest.Verb, cancellationToken: cancellationToken)
                    .ConfigureAwait(false);
            }
            else
            {
                return await flurlRequest
                    .WithClient(FlurlClient)
                    .AllowAnyHttpStatus()
                    .SendJsonAsync(flurlRequest.Verb, data: data, cancellationToken: cancellationToken)
                    .ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public virtual void Dispose()
        {
            FlurlClient?.Dispose();
        }
    }
}
