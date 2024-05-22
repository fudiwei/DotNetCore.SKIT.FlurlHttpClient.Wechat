using System;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatApiClient"/> 时使用的配置项。
    /// </summary>
    public class WechatApiClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>
        /// 默认值：30000
        /// </para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置微信 API 入口点。
        /// <para>
        /// 默认值：<see cref="WechatApiEndpoints.DEFAULT"/>
        /// </para>
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
        /// 获取或设置虚拟支付 AppKey（用于小程序虚拟支付相关接口）。
        /// </summary>
        public string? VirtualPaymentAppKey { get; set; }

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

        /// <summary>
        /// 获取或设置 API 安全鉴权模式是否开启。
        /// </summary>
        public bool SecurityApiEnabled { get; set; }

        /// <summary>
        /// 获取或设置 API 安全鉴权模式所使用的 AppId。如果不指定将使用 <see cref="AppId"/>。
        /// </summary>
        public string? SecurityApiAppId { get; set; }

        /// <summary>
        /// 获取或设置 API 安全鉴权模式对称加密算法。
        /// <para>
        /// 默认值：<see cref="Constants.SecurityApiSymmetricAlgorithms.AES"/>
        /// </para>
        /// </summary>
        public string SecurityApiSymmetricAlgorithm { get; set; } = Constants.SecurityApiSymmetricAlgorithms.AES;

        /// <summary>
        /// 获取或设置 API 安全鉴权模式对称加密密钥编号。
        /// </summary>
        public string? SecurityApiSymmetricNumber { get; set; }

        /// <summary>
        /// 获取或设置 API 安全鉴权模式对称加密密钥。
        /// </summary>
        public string? SecurityApiSymmetricKey { get; set; }

        /// <summary>
        /// 获取或设置 API 安全鉴权模式非对称加密算法。
        /// <para>
        /// 默认值：<see cref="Constants.SecurityApiAsymmetricAlgorithms.RSA"/>
        /// </para>
        /// </summary>
        public string SecurityApiAsymmetricAlgorithm { get; set; } = Constants.SecurityApiAsymmetricAlgorithms.RSA;

        /// <summary>
        /// 获取或设置 API 安全鉴权模式非对称加密私钥编号。
        /// </summary>
        public string? SecurityApiAsymmetricNumber { get; set; }

        /// <summary>
        /// 获取或设置 API 安全鉴权模式非对称加密私钥。
        /// </summary>
        public string? SecurityApiAsymmetricPrivateKey { get; set; }

        /// <summary>
        /// 获取或设置 API 安全鉴权模式自定义请求路径匹配器。如果不指定将只匹配关键 API。
        /// </summary>
        public Func<string, bool>? SecurityApiCustomRequestPathMatcher { get; set; }
    }
}
