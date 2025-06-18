namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/order/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillOrderGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class EWaybillOrder
            {
                public static class Types
                {
                    public class Address
                    {
                        /// <summary>
                        /// 获取或设置省份。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province")]
                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                        public string Province { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string City { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置区县。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("county")]
                        [System.Text.Json.Serialization.JsonPropertyName("county")]
                        public string District { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置街道。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("street")]
                        [System.Text.Json.Serialization.JsonPropertyName("street")]
                        public string? Street { get; set; }

                        /// <summary>
                        /// 获取或设置详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string DetailAddress { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置联系人。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置联系电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mobile")]
                        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                        public string MobileNumber { get; set; } = default!;
                    }

                    public class Order
                    {
                        public static class Types
                        {
                            public class Goods
                            {
                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public long? ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                public long? SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置商品名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("good_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("good_name")]
                                public string GoodsName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品个数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("good_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("good_count")]
                                public int GoodsCount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ec_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ec_order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string? OrderId { get; set; }

                        /// <summary>
                        /// 获取或设置商品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_list")]
                        public Types.Goods[] GoodsList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置代发的订单密文。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ewaybill_order_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_code")]
                        public string? EWaybillOrderCode { get; set; }

                        /// <summary>
                        /// 获取或设置代发的订单所属小店 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ewaybill_order_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_appid")]
                        public string? EWaybillOrderAppId { get; set; }
                    }

                    public class Path
                    {
                        /// <summary>
                        /// 获取或设置轨迹状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置轨迹描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置电子面单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ewaybill_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_id")]
                public string EWaybillOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置快递单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("waybill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                public string WaybillId { get; set; } = default!;

                /// <summary>
                /// 获取或设置网点编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("site_code")]
                [System.Text.Json.Serialization.JsonPropertyName("site_code")]
                public string? SiteCode { get; set; }

                /// <summary>
                /// 获取或设置店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                public string ShopId { get; set; } = default!;

                /// <summary>
                /// 获取或设置电子面单账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ewaybill_acct_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ewaybill_acct_id")]
                public string EWaybillAccountId { get; set; } = default!;

                /// <summary>
                /// 获取或设置寄件人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sender")]
                [System.Text.Json.Serialization.JsonPropertyName("sender")]
                public Types.Address Sender { get; set; } = default!;

                /// <summary>
                /// 获取或设置收件人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver")]
                public Types.Address Receiver { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ec_order_list")]
                [System.Text.Json.Serialization.JsonPropertyName("ec_order_list")]
                public Types.Order[] OrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置网点编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置轨迹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path_info")]
                [System.Text.Json.Serialization.JsonPropertyName("path_info")]
                public Types.Path[] PathList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置电子面单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        public Types.EWaybillOrder EWaybillOrder { get; set; } = default!;
    }
}
