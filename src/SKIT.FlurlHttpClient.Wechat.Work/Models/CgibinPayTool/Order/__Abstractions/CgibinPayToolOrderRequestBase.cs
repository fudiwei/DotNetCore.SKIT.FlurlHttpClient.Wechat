namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    public abstract class CgibinPayToolOrderRequestBase : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置随机字符串。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nonce_str")]
        [System.Text.Json.Serialization.JsonPropertyName("nonce_str")]
        public string? NonceString { get; set; }

        /// <summary>
        /// 获取或设置请求时间戳。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ts")]
        [System.Text.Json.Serialization.JsonPropertyName("ts")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// 获取或设置请求数字签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sig")]
        [System.Text.Json.Serialization.JsonPropertyName("sig")]
        public string? Signature { get; set; }
    }
}
