using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatOpenAIClient"/> 时使用的配置项。
    /// </summary>
    public class WechatOpenAIClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置微信智能对话 API 入口点。
        /// <para>默认值：<see cref="WechatOpenAIEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = WechatOpenAIEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置微信智能对话 AppId。
        /// </summary>
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信智能对话 Token。
        /// </summary>
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信智能对话 EncodingAESKey。
        /// </summary>
        public string EncodingAESKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义需加密请求路径匹配器。
        /// </summary>
        public Func<string, bool>? CustomEncryptedRequestPathMatcher { get; set; }
    }
}
