namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatApiClient"/> 时使用的配置项。
    /// </summary>
    public class WechatApiClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置微信 API 入口点。
        /// <para>默认值：<see cref="WechatApiEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = WechatApiEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppSecret。
        /// </summary>
        public string AppSecret { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信服务器推送的 EncodingAESKey。
        /// </summary>
        public string? PushEncodingAESKey { get; set; }

        /// <summary>
        /// 获取或设置微信服务器推送的 Token。
        /// </summary>
        public string? PushToken { get; set; }

        /// <summary>
        /// 获取或设置即时配送公司帐号 AppKey（用于小程序即使配送相关接口）。
        /// </summary>
        public string? ImmeDeliveryAppKey { get; set; }

        /// <summary>
        /// 获取或设置即时配送公司帐号 AppSecret（用于小程序即使配送相关接口）。
        /// </summary>
        public string? ImmeDeliveryAppSecret { get; set; }

        /// <summary>
        /// 获取或设置米大师平台 OfferId（用于小游戏虚拟支付 1.0 相关接口）。
        /// </summary>
        public string? MidasOfferId { get; set; }

        /// <summary>
        /// 获取或设置米大师平台 AppKey（用于小游戏虚拟支付 1.0 相关接口）。
        /// </summary>
        public string? MidasAppKey { get; set; }

        /// <summary>
        /// 获取或设置米大师平台 OfferId（用于小游戏虚拟支付 2.0 相关接口）。
        /// </summary>
        public string? MidasOfferIdV2 { get; set; }

        /// <summary>
        /// 获取或设置米大师平台 AppKey（用于小游戏虚拟支付 2.0 相关接口）。
        /// </summary>
        public string? MidasAppKeyV2 { get; set; }
    }
}
