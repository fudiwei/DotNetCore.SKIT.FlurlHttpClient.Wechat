namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.transport_precreate_order" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onOrderPreAdd.html ]]>
    /// </para>
    /// </summary>
    public class TransportPreCreateOrderEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Sender
            {
                /// <summary>
                /// 获取或设置姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                [System.Xml.Serialization.XmlElement("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                [System.Xml.Serialization.XmlElement("city")]
                public string? City { get; set; }

                /// <summary>
                /// 获取或设置地址（街道、小区、大厦等）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                [System.Xml.Serialization.XmlElement("address")]
                public string? Address { get; set; }

                /// <summary>
                /// 获取或设置地址详情（楼号、单元号、层号等）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("address_detail")]
                [System.Xml.Serialization.XmlElement("address_detail")]
                public string? AddressDetail { get; set; }

                /// <summary>
                /// 获取或设置电话或手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                [System.Xml.Serialization.XmlElement("phone")]
                public string? PhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置经度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lng")]
                [System.Text.Json.Serialization.JsonPropertyName("lng")]
                [System.Xml.Serialization.XmlElement("lng")]
                public decimal Longitude { get; set; }

                /// <summary>
                /// 获取或设置纬度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lat")]
                [System.Text.Json.Serialization.JsonPropertyName("lat")]
                [System.Xml.Serialization.XmlElement("lat")]
                public decimal Latitude { get; set; }

                /// <summary>
                /// 获取或设置坐标类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coordinate_type")]
                [System.Text.Json.Serialization.JsonPropertyName("coordinate_type")]
                [System.Xml.Serialization.XmlElement("coordinate_type", IsNullable = true)]
                public int? CoordinateType { get; set; }
            }

            public class Receiver : Sender
            {
            }

            public abstract class __zz__Cargo
            {
                /// <summary>
                /// 获取或设置货物价格（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_value")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_value")]
                [System.Xml.Serialization.XmlElement("goods_value")]
                public decimal GoodsVaue { get; set; }

                /// <summary>
                /// 获取或设置货物高度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_height")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_height")]
                [System.Xml.Serialization.XmlElement("goods_height", IsNullable = true)]
                public decimal? GoodsHeight { get; set; }

                /// <summary>
                /// 获取或设置货物长度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_length")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_length")]
                [System.Xml.Serialization.XmlElement("goods_length", IsNullable = true)]
                public decimal? GoodsLength { get; set; }

                /// <summary>
                /// 获取或设置货物宽度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_width")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_width")]
                [System.Xml.Serialization.XmlElement("goods_width", IsNullable = true)]

                public decimal? GoodsWidth { get; set; }

                /// <summary>
                /// 获取或设置货物重量（单位：千克）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_weight")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_weight")]
                [System.Xml.Serialization.XmlElement("goods_weight", IsNullable = true)]
                public decimal? GoodsWeight { get; set; }

                /// <summary>
                /// 获取或设置货物取货信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_pickup_info")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_pickup_info")]
                [System.Xml.Serialization.XmlElement("goods_pickup_info", IsNullable = true)]
                public string? GoodsPickupInformation { get; set; }

                /// <summary>
                /// 获取或设置货物交付信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_delivery_info")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_delivery_info")]
                [System.Xml.Serialization.XmlElement("goods_delivery_info", IsNullable = true)]
                public string? GoodsDeliveryInformation { get; set; }

                /// <summary>
                /// 获取或设置品类一级类目。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_first_class")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_first_class")]
                [System.Xml.Serialization.XmlElement("cargo_first_class")]
                public string? CargoFirstClass { get; set; }

                /// <summary>
                /// 获取或设置品类二级类目。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_second_class")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_second_class")]
                [System.Xml.Serialization.XmlElement("cargo_second_class")]
                public string? CargoSecondClass { get; set; }
            }

            public class Cargo : __zz__Cargo
            {
                public static class Types
                {
                    public class GoodsDetail
                    {
                        public static class Types
                        {
                            public class Goods
                            {
                                /// <summary>
                                /// 获取或设置货物数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("good_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("good_count")]
                                [System.Xml.Serialization.XmlElement("good_count")]
                                public int Count { get; set; }

                                /// <summary>
                                /// 获取或设置货物名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("good_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("good_name")]
                                [System.Xml.Serialization.XmlElement("good_name")]
                                public string? Name { get; set; }

                                /// <summary>
                                /// 获取或设置货物单价（单位：元）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("good_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("good_price")]
                                [System.Xml.Serialization.XmlElement("good_price", IsNullable = true)]
                                public decimal? Price { get; set; }

                                /// <summary>
                                /// 获取或设置货物单位。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("good_unit")]
                                [System.Text.Json.Serialization.JsonPropertyName("good_unit")]
                                [System.Xml.Serialization.XmlElement("good_unit", IsNullable = true)]
                                public string? Unit { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置货物列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods")]
                        [System.Xml.Serialization.XmlElement("goods", Type = typeof(Types.Goods))]
                        public List<Types.Goods>? GoodsList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置货物详情信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                [System.Xml.Serialization.XmlElement("goods_detail")]
                public Types.GoodsDetail? GoodsDetail { get; set; }
            }

            public class Order
            {
                /// <summary>
                /// 获取或设置配送服务代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_service_code")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_service_code")]
                [System.Xml.Serialization.XmlElement("delivery_service_code")]
                public string? DeliveryServiceCode { get; set; }

                /// <summary>
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                [System.Xml.Serialization.XmlElement("order_type")]
                public int OrderType { get; set; }

                /// <summary>
                /// 获取或设置期望派单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expected_delivery_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expected_delivery_time")]
                [System.Xml.Serialization.XmlElement("expected_delivery_time", IsNullable = true)]
                public long? ExpectedDeliveryTimestamp { get; set; }

                /// <summary>
                /// 获取或设置期望送达时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expected_finish_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expected_finish_time")]
                [System.Xml.Serialization.XmlElement("expected_finish_time", IsNullable = true)]
                public long? ExpectedFinishTimestamp { get; set; }

                /// <summary>
                /// 获取或设置期望取件时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expected_pick_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expected_pick_time")]
                [System.Xml.Serialization.XmlElement("expected_pick_time", IsNullable = true)]
                public long? ExpectedPickTimestamp { get; set; }

                /// <summary>
                /// 获取或设置门店订单流水号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_seq")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_seq")]
                [System.Xml.Serialization.XmlElement("poi_seq", IsNullable = true)]
                public string? POISequence { get; set; }

                /// <summary>
                /// 获取或设置用户下单付款时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_time")]
                [System.Xml.Serialization.XmlElement("order_time", IsNullable = true)]
                public long? OrderTimestamp { get; set; }

                /// <summary>
                /// 获取或设置用户下单付款时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_insured")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_insured")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
                [System.Xml.Serialization.XmlElement("is_insured", IsNullable = true)]
                public bool? IsInsured { get; set; }

                /// <summary>
                /// 获取或设置保价金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("declared_value")]
                [System.Text.Json.Serialization.JsonPropertyName("declared_value")]
                [System.Xml.Serialization.XmlElement("declared_value", IsNullable = true)]
                public decimal? DeclaredValue { get; set; }

                /// <summary>
                /// 获取或设置小费金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tips")]
                [System.Text.Json.Serialization.JsonPropertyName("tips")]
                [System.Xml.Serialization.XmlElement("tips", IsNullable = true)]
                public decimal? TipValue { get; set; }

                /// <summary>
                /// 获取或设置是否选择直拿直送。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_direct_delivery")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_direct_delivery")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
                [System.Xml.Serialization.XmlElement("is_direct_delivery", IsNullable = true)]
                public bool? IsDirectDelivery { get; set; }

                /// <summary>
                /// 获取或设置骑手应付金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cash_on_delivery")]
                [System.Text.Json.Serialization.JsonPropertyName("cash_on_delivery")]
                [System.Xml.Serialization.XmlElement("cash_on_delivery", IsNullable = true)]
                public decimal? CashOnDelivery { get; set; }

                /// <summary>
                /// 获取或设置骑手应收金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cash_on_pickup")]
                [System.Text.Json.Serialization.JsonPropertyName("cash_on_pickup")]
                [System.Xml.Serialization.XmlElement("cash_on_pickup", IsNullable = true)]
                public decimal? CashOnPickup { get; set; }

                /// <summary>
                /// 获取或设置物流流向类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rider_pick_method")]
                [System.Text.Json.Serialization.JsonPropertyName("rider_pick_method")]
                [System.Xml.Serialization.XmlElement("rider_pick_method", IsNullable = true)]
                public int? RiderPickMethod { get; set; }

                /// <summary>
                /// 获取或设置是否骑手必须输入收货码才能完成订单妥投。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_finish_code_needed")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_finish_code_needed")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
                [System.Xml.Serialization.XmlElement("is_finish_code_needed", IsNullable = true)]
                public bool? IsFinishCodeRequired { get; set; }

                /// <summary>
                /// 获取或设置是否骑手必须输入取货码才能从商家取货。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_pickup_code_needed")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_pickup_code_needed")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
                [System.Xml.Serialization.XmlElement("is_pickup_code_needed", IsNullable = true)]
                public bool? IsPickupCodeRequired { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("note")]
                [System.Text.Json.Serialization.JsonPropertyName("note")]
                [System.Xml.Serialization.XmlElement("note", IsNullable = true)]
                public string? Remark { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shopid")]
        [System.Text.Json.Serialization.JsonPropertyName("shopid")]
        [System.Xml.Serialization.XmlElement("shopid")]
        public string? ShopId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
        [System.Xml.Serialization.XmlElement("shop_order_id")]
        public string? ShopOrderId { get; set; }

        /// <summary>
        /// 获取或设置商家门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_no")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_no")]
        [System.Xml.Serialization.XmlElement("shop_no")]
        public string? ShopNumber { get; set; }

        /// <summary>
        /// 获取或设置校验串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_sign")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_sign")]
        [System.Xml.Serialization.XmlElement("delivery_sign")]
        public string? DeliverySignature { get; set; }

        /// <summary>
        /// 获取或设置发件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender")]
        [System.Text.Json.Serialization.JsonPropertyName("sender")]
        [System.Xml.Serialization.XmlElement("sender")]
        public Types.Sender? Sender { get; set; }

        /// <summary>
        /// 获取或设置收件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver")]
        [System.Xml.Serialization.XmlElement("receiver")]
        public Types.Receiver? Receiver { get; set; }

        /// <summary>
        /// 获取或设置货物信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cargo")]
        [System.Text.Json.Serialization.JsonPropertyName("cargo")]
        [System.Xml.Serialization.XmlElement("cargo")]
        public Types.Cargo? Cargo { get; set; }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        [System.Xml.Serialization.XmlElement("order_info")]
        public Types.Order? Order { get; set; }
    }
}
