namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/get_order_list 接口的响应。</para>
    /// </summary>
    public class WxaSecOrderGetOrderListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order
            {
                public static class Types
                {
                    public class Shipping
                    {
                        public static class Types
                        {
                            public class Shipping
                            {
                                public static class Types
                                {
                                    public class Contact
                                    {
                                        /// <summary>
                                        /// 获取或设置寄件人联系方式。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("consignor_contact")]
                                        [System.Text.Json.Serialization.JsonPropertyName("consignor_contact")]
                                        public string? ConsignorContact { get; set; }

                                        /// <summary>
                                        /// 获取或设置收件人联系方式。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("receiver_contact")]
                                        [System.Text.Json.Serialization.JsonPropertyName("receiver_contact")]
                                        public string? ReceiverContact { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置物流公司编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("express_company")]
                                [System.Text.Json.Serialization.JsonPropertyName("express_company")]
                                public string? ExpressCompany { get; set; }

                                /// <summary>
                                /// 获取或设置物流单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tracking_no")]
                                [System.Text.Json.Serialization.JsonPropertyName("tracking_no")]
                                public string? TrackingNumber { get; set; }

                                /// <summary>
                                /// 获取或设置商品信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("goods_desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("goods_desc")]
                                public string? ItemDescription { get; set; }

                                /// <summary>
                                /// 获取或设置联系信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("contact")]
                                [System.Text.Json.Serialization.JsonPropertyName("contact")]
                                public Types.Contact? Contact { get; set; }

                                /// <summary>
                                /// 获取或设置上传时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("upload_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("upload_time")]
                                public long UploadTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置物流形式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logistics_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("logistics_type")]
                        public int LogisticsType { get; set; }

                        /// <summary>
                        /// 获取或设置发货模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_mode")]
                        public int DeliveryMode { get; set; }

                        /// <summary>
                        /// 获取或设置商品描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_desc")]
                        public string? ItemDescription { get; set; }

                        /// <summary>
                        /// 获取或设置发货模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finish_shipping")]
                        [System.Text.Json.Serialization.JsonPropertyName("finish_shipping")]
                        public bool IsFinishAll { get; set; }

                        /// <summary>
                        /// 获取或设置已完成全部发货的次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finish_shipping_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("finish_shipping_count")]
                        public int FinishCount { get; set; }

                        /// <summary>
                        /// 获取或设置物流信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_list")]
                        public Types.Shipping[] ShippingList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置支付下单商户的商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_id")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
                public string MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付下单商户的子商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_merchant_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_merchant_id")]
                public string? SubMerchantId { get; set; }

                /// <summary>
                /// 获取或设置原支付交易的商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_trade_no")]
                public string OutTradeNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置原支付交易的微信订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                public string? TransactionId { get; set; }

                /// <summary>
                /// 获取或设置商品描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付者的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置实付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("paid_amount")]
                public int PayAmount { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_state")]
                [System.Text.Json.Serialization.JsonPropertyName("order_state")]
                public int OrderState { get; set; }

                /// <summary>
                /// 获取或设置支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                public long? PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置是否处在交易纠纷中。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("in_complaint")]
                [System.Text.Json.Serialization.JsonPropertyName("in_complaint")]
                public bool IsInComplaint { get; set; }

                /// <summary>
                /// 获取或设置发货信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping")]
                public Types.Shipping? Shipping { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public Types.Order[] OrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有下一页。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置下一页分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_index")]
        [System.Text.Json.Serialization.JsonPropertyName("last_index")]
        public string? Offset { get; set; }
    }
}
