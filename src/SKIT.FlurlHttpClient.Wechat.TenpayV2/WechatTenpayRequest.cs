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
    }

    /// <summary>
    /// 表示微信支付 API 请求的基类。
    /// </summary>
    public abstract class WechatTenpaySignRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置随机字符串。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nonce_str")]
        [System.Text.Json.Serialization.JsonPropertyName("nonce_str")]
        public virtual string? NonceString { get; set; }

        /// <summary>
        /// 获取或设置请求签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public virtual string? Signature { get; set; }
    }
}
