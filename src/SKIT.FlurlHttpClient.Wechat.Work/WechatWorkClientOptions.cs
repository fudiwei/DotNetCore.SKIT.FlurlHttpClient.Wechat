using System;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatWorkClient"/> 时使用的配置项。
    /// </summary>
    public class WechatWorkClientOptions
    {
        /// <summary>
        /// <para>获取或设置请求超时时间（单位：毫秒）。</para>
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// <para>获取或设置企业微信 API 域名。</para>
        /// <para>默认值：<see cref="WechatWorkEndpoints.DEFAULT"/></para>
        /// </summary>
        public string? Endpoints { get; set; } = WechatWorkEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置企业微信 CorpId。
        /// </summary>
        public string CorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业微信应用的 AgentId。
        /// </summary>
        public int AgentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业微信应用的 AgentSecret。
        /// </summary>
        public string AgentSecret { get; set; } = default!;
    }
}
