namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/getgoodswarehouse 接口的响应。</para>
    /// </summary>
    public class WxaApiBroadcastGetGoodsWarehouseResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Goods
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_id")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_id")]
                public long GoodsId { get; set; }

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序商品详情页路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string PagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品封面图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cover_img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("cover_img_url")]
                public string CoverImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置价格类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price_type")]
                [System.Text.Json.Serialization.JsonPropertyName("price_type")]
                public int PriceType { get; set; }

                /// <summary>
                /// 获取或设置价格 1（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public decimal Price1 { get; set; }

                /// <summary>
                /// 获取或设置价格 2（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price2")]
                [System.Text.Json.Serialization.JsonPropertyName("price2")]
                public decimal Price2 { get; set; }

                /// <summary>
                /// 获取或设置审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                public int AuditStatus { get; set; }

                /// <summary>
                /// 获取或设置第三方小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thirdPartyAppid")]
                [System.Text.Json.Serialization.JsonPropertyName("thirdPartyAppid")]
                public string? ThirdPartyAppId { get; set; }

                /// <summary>
                /// 获取或设置第三方小程序标签。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_party_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("third_party_tag")]
                public int? ThirdPartyTag { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods")]
        [System.Text.Json.Serialization.JsonPropertyName("goods")]
        public Types.Goods[] GoodsList { get; set; } = default!;

        /// <summary>
        /// 获取或设置商品数数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Count { get; set; }
    }
}
