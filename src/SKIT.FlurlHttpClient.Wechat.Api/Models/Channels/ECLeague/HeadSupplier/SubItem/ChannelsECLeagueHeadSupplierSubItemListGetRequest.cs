namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/subitem/list/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierSubItemListGetRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierSubItemListGetRequest, ChannelsECLeagueHeadSupplierSubItemListGetResponse>
    {
        /// <summary>
        /// 获取或设置机构合作计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cooperative_item_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cooperative_item_id")]
        public long CooperativeItemId { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? Cursor { get; set; }
    }
}
