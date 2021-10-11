namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatOpenAIThirdPartyClient"/> 时使用的配置项。
    /// </summary>
    public class WechatOpenAIThirdPartyClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置微信智能对话 API 域名。
        /// <para>默认值：<see cref="WechatOpenAIPlatformEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = WechatOpenAIPlatformEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置微信智能对话 ClientId。
        /// </summary>
        public string ClientId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信智能对话 ClientKey。
        /// </summary>
        public string ClientKey { get; set; } = string.Empty;
    }
}
