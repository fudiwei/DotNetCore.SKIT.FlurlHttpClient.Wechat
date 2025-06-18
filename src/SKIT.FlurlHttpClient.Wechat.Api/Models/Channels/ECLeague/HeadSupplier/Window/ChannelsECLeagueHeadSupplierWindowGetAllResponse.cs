namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/window/getall 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierWindowGetAllResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                /// <summary>
                /// 获取或设置小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置团长 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_supplier_id")]
                [System.Text.Json.Serialization.JsonPropertyName("head_supplier_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long HeadSupplierId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Product[] ProductList { get; set; } = default!;

        /// <summary>
        /// 获取或设置下一页分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_offset")]
        [System.Text.Json.Serialization.JsonPropertyName("next_offset")]
        public int NextOffset { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("have_more")]
        [System.Text.Json.Serialization.JsonPropertyName("have_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int? TotalCount { get; set; }
    }
}
