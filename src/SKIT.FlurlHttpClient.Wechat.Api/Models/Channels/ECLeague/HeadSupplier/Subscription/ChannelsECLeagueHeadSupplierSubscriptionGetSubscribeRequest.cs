namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/subscription/getsubscribe 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierSubscriptionGetSubscribeRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierSubscriptionGetSubscribeRequest, ChannelsECLeagueHeadSupplierSubscriptionGetSubscribeResponse>
    {
        public static class Types
        {
            public class Filter
            {
                /// <summary>
                /// 获取或设置小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string? ShopAppId { get; set; }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public long? ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_name")]
                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                public string? ProductName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置筛选条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter")]
        [System.Text.Json.Serialization.JsonPropertyName("filter")]
        public Types.Filter? Filter { get; set; }

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

        /// <summary>
        /// 获取或设置是否返回总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("need_total_num")]
        public bool? RequireTotalCount { get; set; }
    }
}
