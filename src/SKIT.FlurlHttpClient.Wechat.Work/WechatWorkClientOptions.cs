namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatWorkClient"/> 时使用的配置项。
    /// </summary>
    public class WechatWorkClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置企业微信 API 域名。
        /// <para>默认值：<see cref="WechatWorkEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = WechatWorkEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置企业微信 CorpId。
        /// </summary>
        public string CorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业微信应用的 AgentId。仅限企业内部开发时使用。
        /// </summary>
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置企业微信应用的 AgentSecret。仅限企业内部开发时使用。
        /// </summary>
        public string? AgentSecret { get; set; }

        /// <summary>
        /// 获取或设置企业微信服务商 Secret。仅限第三方应用开发或服务商代开发时使用。
        /// </summary>
        public string? ProviderSecret { get; set; }

        /// <summary>
        /// 获取或设置企业微信第三方应用的 SuiteId。仅限第三方应用开发或服务商代开发时使用。
        /// </summary>
        public string? SuiteId { get; set; }

        /// <summary>
        /// 获取或设置企业微信第三方应用的 SuiteSecret。仅限第三方应用开发或服务商代开发时使用。
        /// </summary>
        public string? SuiteSecret { get; set; }

        /// <summary>
        /// 获取或设置企业微信硬件型号的 ModelId。仅限智慧硬件开发时使用。
        /// </summary>
        public string? ModelId { get; set; }

        /// <summary>
        /// 获取或设置企业微信硬件型号的 ModelSecret。仅限智慧硬件开发时使用。
        /// </summary>
        public string? ModelSecret { get; set; }

        /// <summary>
        /// 获取或设置企业微信服务器推送的 EncodingAESKey。
        /// </summary>
        public string? PushEncodingAESKey { get; set; }

        /// <summary>
        /// 获取或设置企业微信服务器推送的 Token。
        /// </summary>
        public string? PushToken { get; set; }
    }
}
