namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/stores 接口的响应。</para>
    /// </summary>
    public class QueryMarketingGoodsSubsidyActivityRetailStoresResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Store
            {
                /// <summary>
                /// 获取或设置门店编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_code")]
                [System.Text.Json.Serialization.JsonPropertyName("store_code")]
                public string StoreCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置门店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_name")]
                [System.Text.Json.Serialization.JsonPropertyName("store_name")]
                public string StoreName { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Store[]? StoreList { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }
    }
}
