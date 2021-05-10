using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 微信支付 API 接口签名认证方式。
    /// </summary>
    public static class WechatTenpayAuthSchemes
    {
        /// <summary>
        /// WECHATPAY2-SHA256-RSA2048（默认）。
        /// </summary>
        public const string WECHATPAY2_SHA256_RSA2048 = "WECHATPAY2-SHA256-RSA2048";
    }
}
