using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 表示微信支付 API 响应的基类。
    /// </summary>
    public abstract class WechatTenpayResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取微信支付 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public virtual string? ErrorCode { get; set; }

        /// <summary>
        /// 获取微信支付 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取微信支付 API 返回的错误详细信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public virtual Dictionary<string, object>? ErrorDetail { get; set; }

        /// <summary>
        /// 获取微信请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WechatpayRequestId { get { return GetRawHeaders().GetFirstValueOrEmpty("Request-ID"); } }

        /// <summary>
        /// 获取微信应答时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WechatpayTimestamp { get { return GetRawHeaders().GetFirstValueOrEmpty("Wechatpay-Timestamp"); } }

        /// <summary>
        /// 获取微信应答随机串。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WechatpayNonce { get { return GetRawHeaders().GetFirstValueOrEmpty("Wechatpay-Nonce"); } }

        /// <summary>
        /// 获取微信应答签名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WechatpaySignature { get { return GetRawHeaders().GetFirstValueOrEmpty("Wechatpay-Signature"); } }

        /// <summary>
        /// 获取微信应答签名类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WechatpaySignatureType { get { return GetRawHeaders().GetFirstValueOrEmpty("Wechatpay-Signature-Type"); } }

        /// <summary>
        /// 获取微信应答签名使用的微信支付平台证书序列号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WechatpayCertificateSerialNumber { get { return GetRawHeaders().GetFirstValueOrEmpty("Wechatpay-Serial"); } }

        /// <summary>
        /// 获取一个值，该值指示调用微信 API 是否成功。
        /// <para>
        /// （即 HTTP 状态码为 200/202/204，且 <see cref="ErrorCode"/> 值为空）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() >= 200 && GetRawStatus() <= 204 && string.IsNullOrEmpty(ErrorCode);
        }
    }
}
