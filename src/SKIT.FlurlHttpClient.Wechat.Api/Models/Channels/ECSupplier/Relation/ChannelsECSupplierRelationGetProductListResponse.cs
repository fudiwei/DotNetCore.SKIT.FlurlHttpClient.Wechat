namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/supplier/relation/get_product_list 接口的响应。</para>
    /// </summary>
    public class ChannelsECSupplierRelationGetProductListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Distribution
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置供货商 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_appid")]
                public string SupplierAppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置供货商名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_name")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_name")]
                public string SupplierName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置分配状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("distribute_status")]
                [System.Text.Json.Serialization.JsonPropertyName("distribute_status")]
                public int DistributeStatus { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置分配列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Distribution[] DistributionList { get; set; } = default!;

        /// <summary>
        /// 获取或设置下一页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_context")]
        [System.Text.Json.Serialization.JsonPropertyName("page_context")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
