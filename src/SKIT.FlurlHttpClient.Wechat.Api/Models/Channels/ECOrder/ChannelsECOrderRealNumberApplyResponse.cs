namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/realnumber/apply 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderRealNumberApplyResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置申请 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string TaskId { get; set; } = default!;
    }
}
