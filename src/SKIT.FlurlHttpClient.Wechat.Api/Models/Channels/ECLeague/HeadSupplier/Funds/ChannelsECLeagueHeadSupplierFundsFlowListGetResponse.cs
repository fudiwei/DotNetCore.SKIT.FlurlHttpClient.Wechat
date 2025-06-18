namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/funds/flowlist/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierFundsFlowListGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置资金流水单号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flow_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("flow_ids")]
        public string[] FundsFlowIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }
    }
}
