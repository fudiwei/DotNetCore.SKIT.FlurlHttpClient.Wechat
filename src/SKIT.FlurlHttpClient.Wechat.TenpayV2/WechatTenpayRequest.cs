namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    /// <summary>
    /// 表示微信支付 API 请求的基类。
    /// </summary>
    public abstract class WechatTenpayRequest : ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int? Timeout { get; set; }

        /// <summary>
        /// 获取或设置微信商户号。请不要手动赋值，默认将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public abstract string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.AppId"/> 参数。
        /// <para>注意：部分接口不支持指定，请直接忽略此字段。</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public abstract string? AppId { get; set; }
    }

    /// <summary>
    /// 表示微信支付 API 请求的基类。
    /// </summary>
    public abstract class WechatTenpaySignableRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置随机字符串。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nonce_str")]
        [System.Text.Json.Serialization.JsonPropertyName("nonce_str")]
        public virtual string? NonceString { get; set; }

        /// <summary>
        /// 获取或设置签名方式。
        /// <para>注意：部分接口不支持指定签名方式，请直接忽略此字段。</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_type")]
        public virtual string? SignType { get; set; }

        /// <summary>
        /// 获取或设置签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public virtual string? Signature { get; set; }
    }
}
