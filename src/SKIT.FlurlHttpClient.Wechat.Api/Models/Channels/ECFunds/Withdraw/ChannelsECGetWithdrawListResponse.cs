namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/funds/getwithdrawlist 接口的响应。</para>
    /// </summary>
    public class ChannelsECGetWithdrawListResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置提现单号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_ids")]
        public string[] WithdrawIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置提现单总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
