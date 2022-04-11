namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/scanorderflow 接口的响应。</para>
    /// </summary>
    public class ShopFundsScanOrderFlowResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置资金流水单号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("funds_flow_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("funds_flow_ids")]
        public string[] FundsFlowIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
