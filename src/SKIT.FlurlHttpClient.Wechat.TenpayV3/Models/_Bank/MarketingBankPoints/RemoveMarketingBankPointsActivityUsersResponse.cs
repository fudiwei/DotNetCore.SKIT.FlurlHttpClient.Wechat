namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/bank-points/activity/{activity_id}/users/remove 接口的响应。</para>
    /// </summary>
    public class RemoveMarketingBankPointsActivityUsersResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string? ActivityId { get; set; }
    }
}
