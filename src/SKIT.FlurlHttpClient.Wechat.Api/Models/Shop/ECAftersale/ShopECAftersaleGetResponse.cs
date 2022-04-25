namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ecaftersale/get 接口的响应。</para>
    /// </summary>
    public class ShopECAftersaleGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AftersaleOrder
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
                        /// 获取或设置商家自定义商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                        public string OutProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public long SKUId { get; set; }

                        /// <summary>
                        /// 获取或设置商家自定义 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                        public string OutSKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置参与售后的商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_cnt")]
                        public int Count { get; set; }
                    }

                    public class Return
                    {
                        /// <summary>
                        /// 获取或设置快递公司 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                        public string DeliveryId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置快递公司名字。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_name")]
                        public string DeliveryName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置快递单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("waybill_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                        public string WaybillId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退货时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_return_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_return_time")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long ReturnTimestamp { get; set; }
                    }

                    public class Media
                    {
                        /// <summary>
                        /// 获取或设置类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("thumb_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("thumb_url")]
                        public string ThumbnailUrl { get; set; } = string.Empty;
                    }

                    public class RefundPayDetail
                    {
                        /// <summary>
                        /// 获取或设置退款单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
                        public string RefundId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置售后单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aftersale_id")]
                [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
                public long AftersaleOrderId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义售后单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_aftersale_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_aftersale_id")]
                public string OutAftersaleOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
                public string OutOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orderamt")]
                [System.Text.Json.Serialization.JsonPropertyName("orderamt")]
                public int RefundAmount { get; set; }

                /// <summary>
                /// 获取或设置退款原因类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_reason_type")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_reason_type")]
                public int RefundReasonType { get; set; }

                /// <summary>
                /// 获取或设置退款原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_reason")]
                public string RefundReason { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long CreateTimeTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long UpdateTimeTimestamp { get; set; }

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置 ReturnId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_id")]
                [System.Text.Json.Serialization.JsonPropertyName("return_id")]
                public string ReturnId { get; set; } = default!;

                /// <summary>
                /// 获取或设置附件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_list")]
                [System.Text.Json.Serialization.JsonPropertyName("media_list")]
                public Types.Media[] MediaList { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_info")]
                [System.Text.Json.Serialization.JsonPropertyName("product_info")]
                public Types.Product Product { get; set; } = default!;

                /// <summary>
                /// 获取或设置退货信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_info")]
                [System.Text.Json.Serialization.JsonPropertyName("return_info")]
                public Types.Return? Return { get; set; }

                /// <summary>
                /// 获取或设置退款信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_pay_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_pay_detail")]
                public Types.RefundPayDetail? RefundPayDetail { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置售后单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sales_order")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sales_order")]
        public Types.AftersaleOrder AftersaleOrder { get; set; } = default!;
    }
}
