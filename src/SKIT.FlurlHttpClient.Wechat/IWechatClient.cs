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
        /// 配置客户端。
        /// </summary>
        /// <param name="configure"></param>
        public void Configure(Action<WechatClientSettings> configure);

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        IFlurlRequest CreateRequest(params object[] urlSegments);

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        IFlurlRequest CreateRequest(HttpMethod method, params object[] urlSegments);
    }
}
