namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/freepublish/submit 接口的响应。</para>
    /// </summary>
    public class CgibinFreePublishSubmitResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置发布任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_id")]
        [System.Text.Json.Serialization.JsonPropertyName("publish_id")]
        public string PublishId { get; set; } = default!;

        /// <summary>
        /// 获取或设置消息数据 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_data_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_data_id")]
        public string? MessageDataId { get; set; }
    }
}
