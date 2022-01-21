using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 表示微信支付 API 响应的基类。
    /// </summary>
    public abstract class WechatTenpayResponse : ICommonResponse
    {
        /// <summary>
        /// 
        /// </summary>
        int ICommonResponse.RawStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IDictionary<string, string> ICommonResponse.RawHeaders { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        byte[] ICommonResponse.RawBytes { get; set; } = default!;

        /// <summary>
        /// 获取原始的 HTTP 响应状态码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int RawStatus
        {
            get { return ((ICommonResponse)this).RawStatus; }
            internal set { ((ICommonResponse)this).RawStatus = value; }
        }

        /// <summary>
        /// 获取原始的 HTTP 响应表头集合。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IDictionary<string, string> RawHeaders
        {
            get { return ((ICommonResponse)this).RawHeaders; }
            internal set { ((ICommonResponse)this).RawHeaders = value; }
        }

        /// <summary>
        /// 获取原始的 HTTP 响应正文。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] RawBytes
        {
            get { return ((ICommonResponse)this).RawBytes; }
            internal set { ((ICommonResponse)this).RawBytes = value; }
        }

        /// <summary>
        /// 获取微信请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WechatpayRequestId { get; internal set; } = default!;

        /// <summary>
        /// 获取微信应答时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WechatpayTimestamp { get; internal set; } = default!;

        /// <summary>
        /// 获取微信应答随机串。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WechatpayNonce { get; internal set; } = default!;

        /// <summary>
        /// 获取微信应答签名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WechatpaySignature { get; internal set; } = default!;

        /// <summary>
        /// 获取微信应答签名使用的微信支付平台证书序列号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WechatpayCertSerialNumber { get; internal set; } = default!;

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
        /// 获取一个值，该值指示调用微信 API 是否成功（即 HTTP 状态码为 200 或 204、且 code 值为空）。
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            return (RawStatus == 200 || RawStatus == 204) && string.IsNullOrEmpty(ErrorCode);
        }
    }
}
