namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/game/content_spam/media_check_sync 接口的请求。</para>
    /// </summary>
    public class WxaGameContentSpamMediaCheckSyncRequest : WechatApiRequest, IInferable<WxaGameContentSpamMediaCheckSyncRequest, WxaGameContentSpamMediaCheckSyncResponse>
    {
        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置多媒体 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_url")]
        [System.Text.Json.Serialization.JsonPropertyName("media_url")]
        public string MediaUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置多媒体类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_type")]
        [System.Text.Json.Serialization.JsonPropertyName("media_type")]
        public int MediaType { get; set; }

        /// <summary>
        /// 获取或设置版本号。
        /// <para>默认值：2</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public int Version { get; set; } = 2;

        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public int Scene { get; set; }
    }
}
