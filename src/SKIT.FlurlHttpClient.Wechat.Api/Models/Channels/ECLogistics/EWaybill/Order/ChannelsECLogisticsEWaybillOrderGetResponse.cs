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
                    public class Address : ChannelsECLogisticsEWaybillOrderPrecreateRequest.Types.Address
                    {
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
                                public string? GoodsName { get; set; }

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
                        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                        public string? OrderId { get; set; }

                        /// <summary>
                        /// 获取或设置商品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_list")]
                        public List<Types.Goods>? GoodsList { get; set; }

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
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }
                    }

                    public class OrderVas : ChannelsECLogisticsEWaybillOrderCreateRequest.Types.OrderVas
                    {
                    }

                    public class EWaybillExtra : ChannelsECLogisticsEWaybillOrderCreateRequest.Types.EWaybillExtra
                    {
                    }

                    public class LogisticsService
                    {
                        /// <summary>
                        /// 获取或设置服务名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_name")]
                        public string? ServiceName { get; set; }
                    }

                    public class ConsolidationWaybill
                    {
                        /// <summary>
                        /// 获取或设置 B 段运单的快递公司 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("b_segment_delivery_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("b_segment_delivery_id")]
                        public string? BSegmentDeliveryId { get; set; }

                        /// <summary>
                        /// 获取或设置 B 段运单的电子面单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("b_segment_ewaybill_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("b_segment_ewaybill_order_id")]
                        public string? BSegmentEWaybillOrderId { get; set; }

                        /// <summary>
                        /// 获取或设置 B 段运单的快递单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("b_segment_waybill_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("b_segment_waybill_id")]
                        public string? BSegmentWaybillId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                public int OrderType { get; set; }

                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string? DeliveryId { get; set; }

                /// <summary>
                /// 获取或设置电子面单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ewaybill_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_id")]
                public string? EWaybillOrderId { get; set; }

                /// <summary>
                /// 获取或设置快递单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("waybill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                public string? WaybillId { get; set; }

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
                public string? ShopId { get; set; }

                /// <summary>
                /// 获取或设置电子面单账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ewaybill_acct_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ewaybill_acct_id")]
                public string? EWaybillAccountId { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置寄件人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sender")]
                [System.Text.Json.Serialization.JsonPropertyName("sender")]
                public Types.Address? Sender { get; set; }

                /// <summary>
                /// 获取或设置收件人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver")]
                public Types.Address? Receiver { get; set; }

                /// <summary>
                /// 获取或设置订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ec_order_list")]
                [System.Text.Json.Serialization.JsonPropertyName("ec_order_list")]
                public List<Types.Order>? OrderList { get; set; }

                /// <summary>
                /// 获取或设置面单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置轨迹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path_info")]
                [System.Text.Json.Serialization.JsonPropertyName("path_info")]
                public List<Types.Path>? PathList { get; set; }

                /// <summary>
                /// 获取或设置月结账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("monthly_card")]
                [System.Text.Json.Serialization.JsonPropertyName("monthly_card")]
                public string? MonthlyCard { get; set; }

                /// <summary>
                /// 获取或设置增值服务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_vas_list")]
                [System.Text.Json.Serialization.JsonPropertyName("order_vas_list")]
                public List<Types.OrderVas>? OrderVasList { get; set; }

                /// <summary>
                /// 获取或设置面单补充信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ext_info")]
                [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
                public Types.EWaybillExtra? EWaybillExtra { get; set; }

                /// <summary>
                /// 获取或设置物流服务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logistics_service_info")]
                [System.Text.Json.Serialization.JsonPropertyName("logistics_service_info")]
                public List<Types.LogisticsService>? LogisticsServiceList { get; set; }

                /// <summary>
                /// 获取或设置集运运单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consolidation_waybill_info")]
                [System.Text.Json.Serialization.JsonPropertyName("consolidation_waybill_info")]
                public Types.ConsolidationWaybill? ConsolidationWaybill { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置电子面单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        public Types.EWaybillOrder? EWaybillOrder { get; set; }
    }
}
