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
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long PublishId { get; set; }

        /// <summary>
        /// 获取或设置消息数据 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_data_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_data_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
        public string? MessageDataId { get; set; }
    }
}
