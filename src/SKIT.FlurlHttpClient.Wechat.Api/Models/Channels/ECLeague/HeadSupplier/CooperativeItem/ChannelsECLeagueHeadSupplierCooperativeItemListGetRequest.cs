namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/cooperativeitem/list/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierCooperativeItemListGetRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierCooperativeItemListGetRequest, ChannelsECLeagueHeadSupplierCooperativeItemListGetResponse>
    {
        public static class Types
        {
            public class Range
            {
                /// <summary>
                /// 获取或设置最小值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("min")]
                [System.Text.Json.Serialization.JsonPropertyName("min")]
                public long Mininum { get; set; }

                /// <summary>
                /// 获取或设置最大值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max")]
                [System.Text.Json.Serialization.JsonPropertyName("max")]
                public long Maxinum { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置佣金分配类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commission_type")]
        [System.Text.Json.Serialization.JsonPropertyName("commission_type")]
        public int CommissionType { get; set; }

        /// <summary>
        /// 获取或设置上架时间戳范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("listing_time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("listing_time_range")]
        public Types.Range? ListingTimestampRange { get; set; }

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
