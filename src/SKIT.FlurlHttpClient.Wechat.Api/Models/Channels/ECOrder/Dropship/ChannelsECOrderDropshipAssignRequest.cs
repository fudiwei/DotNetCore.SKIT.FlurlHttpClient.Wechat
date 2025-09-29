using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/dropship/assign 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderDropshipAssignRequest : WechatApiRequest, IInferable<ChannelsECOrderDropshipAssignRequest, ChannelsECOrderDropshipAssignResponse>
    {
        public static class Types
        {
            public class DropshipProduct
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_id")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("spu_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置商品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("product_cnt")]
                public int Count { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置供货商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_appid")]
        public string SupplierAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置代发商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dropship_product_list")]
        [System.Text.Json.Serialization.JsonPropertyName("dropship_product_list")]
        public IList<Types.DropshipProduct> DropshipProductList { get; set; } = new List<Types.DropshipProduct>();
    }
}
