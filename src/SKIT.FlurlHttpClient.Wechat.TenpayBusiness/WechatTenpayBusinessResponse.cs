using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    /// <summary>
    /// 表示微企付 API 响应的基类。
    /// </summary>
    public abstract class WechatTenpayBusinessResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取微企付 API 返回的敏感字段加密参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public WechatTenpayBusinessResponseEncryption? WechatpayEncryption { get; internal set; }

        /// <summary>
        /// 获取微企付请求链路 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trace_id")]
        [System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public virtual string? TraceId { get; set; }

        /// <summary>
        /// 获取微企付 API 返回的错误详细信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error")]
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public virtual WechatTenpayBusinessResponseError? Error { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用微企付 API 是否成功。
        /// <para>
        /// （即 HTTP 状态码为 200/202/204，且 <see cref="Error.Code"/> 值为空）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() >= 200 && GetRawStatus() <= 204 && string.IsNullOrEmpty(Error?.Code);
        }
    }

    public sealed class WechatTenpayBusinessResponseError
    {
        /// <summary>
        /// 获取或设置错误代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 获取或设置错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置错误详细信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public IDictionary<string, string>? Details { get; set; }
    }

    public sealed class WechatTenpayBusinessResponseEncryption
    {
        /// <summary>
        /// 获取或设置平台账号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? PlatformId { get; set; }

        /// <summary>
        /// 获取或设置企业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// 获取或设置加密后的密钥值。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? EncryptedKey { get; set; }

        /// <summary>
        /// 获取或设置 CBC IV。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? IV { get; set; }

        /// <summary>
        /// 获取或设置平台证书序列号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SerialNumber { get; set; }

        /// <summary>
        /// 获取或设置加密算法。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Algorithm { get; set; }
    }
}
