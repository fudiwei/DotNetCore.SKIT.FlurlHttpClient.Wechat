namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    public abstract class WxaGamePaymentRequestBase : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置虚拟支付应用 ID。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.MidasOfferIdV2"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offer_id")]
        [System.Text.Json.Serialization.JsonPropertyName("offer_id")]
        public string? OfferId { get; set; }

        /// <summary>
        /// 获取或设置虚拟支付分区 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zone_id")]
        [System.Text.Json.Serialization.JsonPropertyName("zone_id")]
        public string ZoneId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置虚拟支付环境。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public int Environment { get; set; }

        /// <summary>
        /// 获取或设置用户 IP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_ip")]
        [System.Text.Json.Serialization.JsonPropertyName("user_ip")]
        public string? UserIp { get; set; }

        /// <summary>
        /// 获取或设置请求时间戳。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ts")]
        [System.Text.Json.Serialization.JsonPropertyName("ts")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// 获取或设置用于用户登录态签名的会话密钥。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SessionKey { get; set; }

        /// <summary>
        /// 获取或设置用于用户登录态签名的方式。
        /// <para>默认值：<see cref="Constants.MidasSignMethods.HMAC_SHA256"/></para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SignMethod { get; set; } = Constants.MidasSignMethods.HMAC_SHA256;

        /// <summary>
        /// 获取或设置用户登录态签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Signature { get; set; }

        /// <summary>
        /// 获取或设置支付签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? PaySign { get; set; }

        protected internal abstract string GetRequestPath();
    }
}
