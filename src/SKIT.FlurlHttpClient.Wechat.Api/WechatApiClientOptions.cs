using System;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatApiClient"/> 时使用的配置项。
    /// </summary>
    public class WechatApiClientOptions
    {
        /// <summary>
        /// <para>获取或设置请求超时时间（单位：毫秒）。</para>
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// <para>获取或设置微信 API 域名。</para>
        /// <para>默认值：<see cref="WechatApiEndpoints.DEFAULT"/></para>
        /// </summary>
        public string? Endpoints { get; set; } = WechatApiEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppSecret。
        /// </summary>
        public string AppSecret { get; set; } = default!;
    }
}
