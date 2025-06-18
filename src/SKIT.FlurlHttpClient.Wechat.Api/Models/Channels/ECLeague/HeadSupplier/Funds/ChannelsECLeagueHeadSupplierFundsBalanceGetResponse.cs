namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/funds/balance/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierFundsBalanceGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置可用余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("available_amount")]
        public int AvailableAmount { get; set; }

        /// <summary>
        /// 获取或设置待结算余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pending_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("pending_amount")]
        public int PendingAmount { get; set; }
    }
}
