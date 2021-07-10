using System;
using System.Net.Http;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat
{
    /// <summary>
    /// SKIT.FlurlHttpClient.Wechat 客户端接口。
    /// </summary>
    public interface IWechatClient : IDisposable
    {
        /// <summary>
        /// 获取当前客户端的拦截器集合。
        /// </summary>
        public WechatHttpCallInterceptorCollection Interceptors { get; }

        /// <summary>
        /// 配置客户端。
        /// </summary>
        /// <param name="configure"></param>
        public void Configure(Action<WechatClientSettings> configure);
    }
}
