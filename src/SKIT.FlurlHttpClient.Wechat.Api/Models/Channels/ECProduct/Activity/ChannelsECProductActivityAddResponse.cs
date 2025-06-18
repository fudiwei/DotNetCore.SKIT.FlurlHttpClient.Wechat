namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/activity/add 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductActivityAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置买赠活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long ActivityId { get; set; }
    }
}
