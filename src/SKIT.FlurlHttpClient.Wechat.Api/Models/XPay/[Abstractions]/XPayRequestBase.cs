namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    public abstract class XPayRequestBase : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

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
        /// 获取或设置平台类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_type")]
        [System.Text.Json.Serialization.JsonPropertyName("device_type")]
        public int? DeviceType { get; set; }

        /// <summary>
        /// 获取或设置用于用户登录态签名的会话密钥。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SessionKey { get; set; }

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
