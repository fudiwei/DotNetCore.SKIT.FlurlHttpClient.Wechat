namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/get_model_token 接口的请求。</para>
    /// </summary>
    public class CgibinOpenHardwareGetModelTokenRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置设备型号 ID。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.ModelId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_id")]
        [System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 获取或设置设备型号 Secret。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.ModelSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_secret")]
        [System.Text.Json.Serialization.JsonPropertyName("model_secret")]
        public string? ModelSecret { get; set; }

        /// <summary>
        /// 获取或设置企业微信后台推送的 Ticket。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("model_ticket")]
        public string ModelTicket { get; set; } = string.Empty;
    }
}
