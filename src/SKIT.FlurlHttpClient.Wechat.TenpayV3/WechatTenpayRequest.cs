using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 表示微信支付 API 请求的基类。
    /// </summary>
    public abstract class WechatTenpayRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置微信请求使用的微信支付平台证书或公钥 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? WechatpaySerialNumber { get; set; }
    }
}
