using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/order/pre_add 接口的请求。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessOrderPreAddRequest : CgibinExpressLocalBusinessRequestBase
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
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string City { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置地址（街道、小区、大厦等）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string Address { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置地址详情（楼号、单元号、层号等）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("address_detail")]
                public string AddressDetail { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置电话或手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                public string PhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置经度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lng")]
                [System.Text.Json.Serialization.JsonPropertyName("lng")]
                public double Longitude { get; set; }

                /// <summary>
                /// 获取或设置纬度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lat")]
                [System.Text.Json.Serialization.JsonPropertyName("lat")]
                public double Latitude { get; set; }

                /// <summary>
                /// 获取或设置坐标类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coordinate_type")]
                [System.Text.Json.Serialization.JsonPropertyName("coordinate_type")]
                public int? CoordinateType { get; set; }
            }
            
            public class Receiver : Sender
            {
            }

            public class Cargo
            {
                public static class Types
                {
                    public class GoodsDetail
                    {
                        public class Types
                        {
                            public class Goods
                            {
                                /// <summary>
                                /// 获取或设置货物数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("good_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("good_count")]
                                public int Count { get; set; }

                                /// <summary>
                                /// 获取或设置货物名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("good_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("good_name")]
                                public string Name { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置货物单价（单位：元）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("good_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("good_price")]
                                public double? Price { get; set; }

                                /// <summary>
                                /// 获取或设置货物单位。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("good_unit")]
                                [System.Text.Json.Serialization.JsonPropertyName("good_unit")]
                                public string? Unit { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置货物列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods")]
                        public IList<Types.Goods> GoodsList { get; set; } = new List<Types.Goods>();
                    }
                }

                /// <summary>
                /// 获取或设置货物价格（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_value")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_value")]
                public double GoodsVaue { get; set; }

                /// <summary>
                /// 获取或设置货物高度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_height")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_height")]
                public double? GoodsHeight { get; set; }

                /// <summary>
                /// 获取或设置货物长度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_length")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_length")]
                public double? GoodsLength { get; set; }

                /// <summary>
                /// 获取或设置货物宽度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_width")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_width")]
                public double? GoodsWidth { get; set; }

                /// <summary>
                /// 获取或设置货物重量（单位：千克）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_weight")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_weight")]
                public double? GoodsWeight { get; set; }

                /// <summary>
                /// 获取或设置货物详情信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                public Types.GoodsDetail? GoodsDetail { get; set; }

                /// <summary>
                /// 获取或设置货物取货信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_pickup_info")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_pickup_info")]
                public string? GoodsPickupInformation { get; set; }

                /// <summary>
                /// 获取或设置货物交付信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_delivery_info")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_delivery_info")]
                public string? GoodsDeliveryInformation { get; set; }

                /// <summary>
                /// 获取或设置品类一级类目。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_first_class")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_first_class")]
                public string CargoFirstClass { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置品类二级类目。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_second_class")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_second_class")]
                public string CargoSecondClass { get; set; } = string.Empty;
            }

            public class Order
            {
                /// <summary>
                /// 获取或设置配送服务代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_service_code")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_service_code")]
                public string? DeliveryServiceCode { get; set; }

                /// <summary>
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                public int OrderType { get; set; }

                /// <summary>
                /// 获取或设置期望派单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expected_delivery_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expected_delivery_time")]
                public long? ExpectedDeliveryTimestamp { get; set; }

                /// <summary>
                /// 获取或设置期望送达时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expected_finish_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expected_finish_time")]
                public long? ExpectedFinishTimestamp { get; set; }

                /// <summary>
                /// 获取或设置期望取件时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expected_pick_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expected_pick_time")]
                public long? ExpectedPickTimestamp { get; set; }

                /// <summary>
                /// 获取或设置门店订单流水号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_seq")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_seq")]
                public string? POISequence { get; set; }

                /// <summary>
                /// 获取或设置用户下单付款时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_time")]
                public long? OrderTimestamp { get; set; }

                /// <summary>
                /// 获取或设置用户下单付款时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_insured")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_insured")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
                public bool? IsInsured { get; set; }

                /// <summary>
                /// 获取或设置保价金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("declared_value")]
                [System.Text.Json.Serialization.JsonPropertyName("declared_value")]
                public double? DeclaredValue { get; set; }

                /// <summary>
                /// 获取或设置小费金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tips")]
                [System.Text.Json.Serialization.JsonPropertyName("tips")]
                public double? TipValue { get; set; }

                /// <summary>
                /// 获取或设置是否选择直拿直送。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_direct_delivery")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_direct_delivery")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
                public bool? IsDirectDelivery { get; set; }

                /// <summary>
                /// 获取或设置骑手应付金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cash_on_delivery")]
                [System.Text.Json.Serialization.JsonPropertyName("cash_on_delivery")]
                public double? CashOnDelivery { get; set; }

                /// <summary>
                /// 获取或设置骑手应收金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cash_on_pickup")]
                [System.Text.Json.Serialization.JsonPropertyName("cash_on_pickup")]
                public double? CashOnPickup { get; set; }

                /// <summary>
                /// 获取或设置物流流向类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rider_pick_method")]
                [System.Text.Json.Serialization.JsonPropertyName("rider_pick_method")]
                public int? RiderPickMethod { get; set; }

                /// <summary>
                /// 获取或设置是否骑手必须输入收货码才能完成订单妥投。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_finish_code_needed")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_finish_code_needed")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
                public bool? IsFinishCodeRequired { get; set; }

                /// <summary>
                /// 获取或设置是否骑手必须输入取货码才能从商家取货。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_pickup_code_needed")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_pickup_code_needed")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
                public bool? IsPickupCodeRequired { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("note")]
                [System.Text.Json.Serialization.JsonPropertyName("note")]
                public string? Remark { get; set; }
            }

            public class Shop
            {
                /// <summary>
                /// 获取或设置商家小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxa_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("wxa_appid")]
                public string? MiniProgramAppId { get; set; }

                /// <summary>
                /// 获取或设置商家小程序的路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxa_path")]
                [System.Text.Json.Serialization.JsonPropertyName("wxa_path")]
                public string MiniProgramPath { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品缩略图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("img_url")]
                public string ImageUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_name")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                public string GoodsName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_count")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_count")]
                public int GoodsCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商家门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_no")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_no")]
        public string ShopNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置配送公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置下单用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenID { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender")]
        [System.Text.Json.Serialization.JsonPropertyName("sender")]
        public Types.Sender? Sender { get; set; }

        /// <summary>
        /// 获取或设置收件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver")]
        public Types.Receiver Receiver { get; set; } = new Types.Receiver();

        /// <summary>
        /// 获取或设置货物信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cargo")]
        [System.Text.Json.Serialization.JsonPropertyName("cargo")]
        public Types.Cargo Cargo { get; set; } = new Types.Cargo();

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        public Types.Order Order { get; set; } = new Types.Order();

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop")]
        [System.Text.Json.Serialization.JsonPropertyName("shop")]
        public Types.Shop? Shop { get; set; }

        /// <summary>
        /// 获取或设置子商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_biz_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_biz_id")]
        public string? SubBusinessId { get; set; }
    }
}
