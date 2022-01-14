namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/order/getbyid 接口的响应。</para>
    /// </summary>
    public class MerchantOrderGetByIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order
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
                        public string ProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                        public string ProductName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品名称（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_price")]
                        public int ProductPrice { get; set; }

                        /// <summary>
                        /// 获取或设置商品 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_sku")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_sku")]
                        public string ProductSKUInformation { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_count")]
                        public int ProductCount { get; set; }

                        /// <summary>
                        /// 获取或设置商品图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_img")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_img")]
                        public string ProductImageUrl { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public int OrderStatus { get; set; }

                /// <summary>
                /// 获取或设置订单总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_total_price")]
                [System.Text.Json.Serialization.JsonPropertyName("order_total_price")]
                public int OrderTotalFee { get; set; }

                /// <summary>
                /// 获取或设置订单创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_create_time")]
                public int OrderCreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置订单运费（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_express_price")]
                [System.Text.Json.Serialization.JsonPropertyName("order_express_price")]
                public int OrderExpressFee { get; set; }

                /// <summary>
                /// 获取或设置买家 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_openid")]
                public string? BuyerOpenId { get; set; }

                /// <summary>
                /// 获取或设置买家昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_nick")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_nick")]
                public string? BuyerNickname { get; set; }

                /// <summary>
                /// 获取或设置收货人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_name")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_name")]
                public string? ReceiverName { get; set; }

                /// <summary>
                /// 获取或设置收货人省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_province")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_province")]
                public string? ReceiverProvince { get; set; }

                /// <summary>
                /// 获取或设置收货人城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_city")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_city")]
                public string? ReceiverCity { get; set; }

                /// <summary>
                /// 获取或设置收货人区县。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_zone")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_zone")]
                public string? ReceiverDistrict { get; set; }

                /// <summary>
                /// 获取或设置收货人地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_address")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_address")]
                public string? ReceiverAddress { get; set; }

                /// <summary>
                /// 获取或设置收货人手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_mobile")]
                public string? ReceiverMobileNumber { get; set; }

                /// <summary>
                /// 获取或设置收货人固话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_phone")]
                public string? ReceiverTeleNumber { get; set; }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public string? ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_name")]
                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                public string? ProductName { get; set; }

                /// <summary>
                /// 获取或设置商品名称（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_price")]
                [System.Text.Json.Serialization.JsonPropertyName("product_price")]
                public int? ProductPrice { get; set; }

                /// <summary>
                /// 获取或设置商品 SKU 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_sku")]
                [System.Text.Json.Serialization.JsonPropertyName("product_sku")]
                public string? ProductSKUInformation { get; set; }

                /// <summary>
                /// 获取或设置商品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_count")]
                [System.Text.Json.Serialization.JsonPropertyName("product_count")]
                public int? ProductCount { get; set; }

                /// <summary>
                /// 获取或设置商品图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_img")]
                [System.Text.Json.Serialization.JsonPropertyName("product_img")]
                public string? ProductImageUrl { get; set; }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("products")]
                [System.Text.Json.Serialization.JsonPropertyName("products")]
                public Types.Product[]? ProductList { get; set; }

                /// <summary>
                /// 获取或设置物流公司编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_company")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_company")]
                public string? DeliveryCompany { get; set; }

                /// <summary>
                /// 获取或设置运单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string? DeliveryId { get; set; }

                /// <summary>
                /// 获取或设置微信支付交易订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trans_id")]
                [System.Text.Json.Serialization.JsonPropertyName("trans_id")]
                public string? TransactionId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public Types.Order Order { get; set; } = default!;
    }
}
