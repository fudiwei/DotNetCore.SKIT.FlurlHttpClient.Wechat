namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/cooperativeitem/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierCooperativeItemListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CooperativeItem
            {
                /// <summary>
                /// 获取或设置合作商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProjectId { get; set; }

                /// <summary>
                /// 获取或设置机构合作计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cooperative_item_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cooperative_item_id")]
                public long CooperativeItemId { get; set; }

                /// <summary>
                /// 获取或设置计划链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_supplier_item_link")]
                [System.Text.Json.Serialization.JsonPropertyName("head_supplier_item_link")]
                public string HeadSupplierItemLink { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置合作商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.CooperativeItem[] CooperativeItemList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? NextCursor { get; set; }
    }
}
