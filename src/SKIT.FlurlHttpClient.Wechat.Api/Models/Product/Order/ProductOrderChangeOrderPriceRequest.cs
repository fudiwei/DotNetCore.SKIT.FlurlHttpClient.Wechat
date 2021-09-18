using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/order/change_order_price 接口的请求。</para>
    /// </summary>
    public class ProductOrderChangeOrderPriceRequest : WechatApiRequest
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
                /// 获取或设置商品价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("change_price")]
                [System.Text.Json.Serialization.JsonPropertyName("change_price")]
                public int Price { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// 获取或设置是否修改运费。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("change_express")]
        [System.Text.Json.Serialization.JsonPropertyName("change_express")]
        public bool RequireChangeExpress { get; set; }

        /// <summary>
        /// 获取或设置运费价格（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("express_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("express_fee")]
        public int? ExpressFee { get; set; }

        /// <summary>
        /// 获取或设置修改价格的商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("change_order_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("change_order_infos")]
        public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();
    }
}
