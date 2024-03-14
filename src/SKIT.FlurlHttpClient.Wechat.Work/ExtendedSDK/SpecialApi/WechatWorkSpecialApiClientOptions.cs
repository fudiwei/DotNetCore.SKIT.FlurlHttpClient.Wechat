namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.SpecialApi
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatWorkSpecialApiClient"/> 时使用的配置项。
    /// </summary>
    public class WechatWorkSpecialApiClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置企业微信数据分析专区 API 入口点。
        /// <para>默认值：<see cref="WechatWorkSpecialApiEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = WechatWorkSpecialApiEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置企业微信服务商 CorpId。
        /// </summary>
        public string ProviderCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业微信数据分析专区 Secret 。
        /// </summary>
        public string SpecialSecret { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业微信数据分析专区签名密钥。
        /// </summary>
        public string SignSecret { get; set; } = default!;
    }
}
