namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/miniapppay/get_sign 接口的请求。</para>
    /// </summary>
    public class CgibinMiniAppPayGetSignRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预支付交易会话标识	。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prepay_id")]
        [System.Text.Json.Serialization.JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置签名方式。
        /// <para>默认值：RSA</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_type")]
        public string SignType { get; set; } = "RSA";

        /// <summary>
        /// 获取或设置随机字符串。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nonce")]
        [System.Text.Json.Serialization.JsonPropertyName("nonce")]
        public string? Nonce { get; set; }

        /// <summary>
        /// 获取或设置当前时间戳。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp")]
        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public long? Timestamp { get; set; }
    }
}
