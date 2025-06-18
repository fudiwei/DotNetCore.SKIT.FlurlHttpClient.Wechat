namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/cooperativeitem/list/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierCooperativeItemListGetRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierCooperativeItemListGetRequest, ChannelsECLeagueHeadSupplierCooperativeItemListGetResponse>
    {
        /// <summary>
        /// 获取或设置佣金分配类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commission_type")]
        [System.Text.Json.Serialization.JsonPropertyName("commission_type")]
        public int CommissionType { get; set; }

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
