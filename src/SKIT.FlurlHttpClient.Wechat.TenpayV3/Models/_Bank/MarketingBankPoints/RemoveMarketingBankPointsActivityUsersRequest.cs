namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/bank-points/activity/{activity_id}/users/remove 接口的请求。</para>
    /// </summary>
    public class RemoveMarketingBankPointsActivityUsersRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ActivityId { get; set; }

        /// <summary>
        /// 获取或设置协议号 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_id")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_id")]
        public List<string>? ContractIdList { get; set; }
    }
}
