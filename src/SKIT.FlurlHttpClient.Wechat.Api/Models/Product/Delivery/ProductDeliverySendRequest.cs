using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/delivery/send 接口的请求。</para>
    /// </summary>
    public class ProductDeliverySendRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Delivery
            {
                public static class Types
                {
                    public class Product
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public long SKUId { get; set; }

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_cnt")]
                        public int? Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置是否包含订单中所有商品。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_all_product")]
                [System.Text.Json.Serialization.JsonPropertyName("is_all_product")]
                public bool? IsAllProduct { get; set; }

                /// <summary>
                /// 获取或设置快递单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("waybill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                public string? WaybillId { get; set; }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("product_infos")]
                public IList<Types.Product>? ProductList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// 获取或设置快递列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_list")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_list")]
        public IList<Types.Delivery> DeliveryList { get; set; } = new List<Types.Delivery>();
    }
}
