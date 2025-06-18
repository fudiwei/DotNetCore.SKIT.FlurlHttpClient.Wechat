namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/media/voice/translatecontent 接口的响应。</para>
    /// </summary>
    public class CgibinMediaVoiceTranslateContentResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置源内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from_content")]
        [System.Text.Json.Serialization.JsonPropertyName("from_content")]
        public string FromContent { get; set; } = default!;

        /// <summary>
        /// 获取或设置目标内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_content")]
        [System.Text.Json.Serialization.JsonPropertyName("to_content")]
        public string ToContent { get; set; } = default!;
    }
}
