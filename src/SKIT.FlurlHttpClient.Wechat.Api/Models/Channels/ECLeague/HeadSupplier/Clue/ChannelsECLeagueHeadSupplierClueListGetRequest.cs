namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/clue/list/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierClueListGetRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierClueListGetRequest, ChannelsECLeagueHeadSupplierClueListGetResponse>
    {
        public static class Types
        {
            public class TimeRange : ChannelsECOrderListGetRequest.Types.TimeRange
            {
            }
        }

        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? ShopAppId { get; set; }

        /// <summary>
        /// 获取或设置推客 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
        public string? SharerAppId { get; set; }

        /// <summary>
        /// 获取或设置创建订单时间范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_range")]
        public Types.TimeRange? CreateTimeRange { get; set; }

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
