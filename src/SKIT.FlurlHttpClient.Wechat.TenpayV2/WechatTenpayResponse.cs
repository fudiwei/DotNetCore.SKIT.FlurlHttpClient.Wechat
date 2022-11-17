using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
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
        /// 获取微信支付 API 返回的状态码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_code")]
        [System.Text.Json.Serialization.JsonPropertyName("return_code")]
        public virtual string? ReturnCode { get; set; }

        /// <summary>
        /// 获取微信支付 API 返回的状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("return_msg")]
        public virtual string? ReturnMessage { get; set; }

        /// <summary>
        /// 获取微信支付 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_code")]
        [System.Text.Json.Serialization.JsonPropertyName("err_code")]
        public virtual string? ErrorCode { get; set; }

        /// <summary>
        /// 获取微信支付 API 返回的状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_code_des")]
        [System.Text.Json.Serialization.JsonPropertyName("err_code_des")]
        public virtual string? ErrorCodeDescription { get; set; }

        /// <summary>
        /// 获取或设置业务结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_code")]
        [System.Text.Json.Serialization.JsonPropertyName("result_code")]
        public virtual string? ResultCode { get; set; }

        /// <summary>
        /// 获取或设置业务结果描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("result_msg")]
        public virtual string? ResultMessage { get; set; }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public abstract string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// <para>注意：部分接口不支持获取，请直接忽略此字段。</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public abstract string? AppId { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用微信 API 是否成功（即 HTTP 状态码为 200、且 return_code 值 SUCCESS）。
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            bool ret1 = RawStatus == 200 && "SUCCESS".Equals(ReturnCode);
            bool ret2 = string.IsNullOrEmpty(ErrorCode) || "0".Equals(ErrorCode);
            bool ret3 = string.IsNullOrEmpty(ResultCode) || "SUCCESS".Equals(ResultCode);
            return ret1 && ret2 && ret3;
        }
    }

    /// <summary>
    /// 表示微信支付 API 响应的基类。
    /// </summary>
    public abstract class WechatTenpaySignableResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置随机字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nonce_str")]
        [System.Text.Json.Serialization.JsonPropertyName("nonce_str")]
        public virtual string? NonceString { get; set; }

        /// <summary>
        /// 获取或设置签名类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_type")]
        public virtual string? SignType { get; set; }

        /// <summary>
        /// 获取或设置签名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public virtual string? Signature { get; set; }
    }
}
