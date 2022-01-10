using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/business/order/add 接口的请求。</para>
    /// </summary>
    public class CgibinExpressBusinessOrderAddRequest : WechatApiRequest
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
                /// 获取或设置座机号码。与字段 <see cref="MobileNumber"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tel")]
                [System.Text.Json.Serialization.JsonPropertyName("tel")]
                public string? TeleNumber { get; set; }

                /// <summary>
                /// 获取或设置手机号码。与字段 <see cref="TeleNumber"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string? MobileNumber { get; set; }

                /// <summary>
                /// 获取或设置公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company")]
                [System.Text.Json.Serialization.JsonPropertyName("company")]
                public string? Company { get; set; }

                /// <summary>
                /// 获取或设置邮编。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("post_code")]
                [System.Text.Json.Serialization.JsonPropertyName("post_code")]
                public string? PostCode { get; set; }

                /// <summary>
                /// 获取或设置国家。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("country")]
                [System.Text.Json.Serialization.JsonPropertyName("country")]
                public string? Country { get; set; }

                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string Province { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string City { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置区县。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("area")]
                [System.Text.Json.Serialization.JsonPropertyName("area")]
                public string District { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string Address { get; set; } = string.Empty;
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
                        /// <summary>
                        /// 获取或设置商品名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置包裹数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int Count { get; set; }

                /// <summary>
                /// 获取或设置包裹长度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("space_x")]
                [System.Text.Json.Serialization.JsonPropertyName("space_x")]
                public double? Length { get; set; }

                /// <summary>
                /// 获取或设置包裹宽度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("space_y")]
                [System.Text.Json.Serialization.JsonPropertyName("space_y")]
                public double? Width { get; set; }

                /// <summary>
                /// 获取或设置包裹高度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("space_z")]
                [System.Text.Json.Serialization.JsonPropertyName("space_z")]
                public double? Height { get; set; }

                /// <summary>
                /// 获取或设置包裹重量（单位：千克）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("weight")]
                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                public double? Weight { get; set; }

                /// <summary>
                /// 获取或设置商品详情列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_list")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_list")]
                public IList<Types.GoodsDetail>? GoodsDetailList { get; set; }
            }

            public class Shop
            {
                public static class Types
                {
                    public class GoodsDetail
                    {
                        /// <summary>
                        /// 获取或设置商品名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置商品缩略图 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("img_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("img_url")]
                        public string? ImageUrl { get; set; }

                        /// <summary>
                        /// 获取或设置商品详情描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_desc")]
                        public string? Description { get; set; }
                    }
                }

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
                public string? ImageUrl { get; set; }

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_name")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                public string? GoodsName { get; set; }

                /// <summary>
                /// 获取或设置商品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_count")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_count")]
                public int? GoodsCount { get; set; }

                /// <summary>
                /// 获取或设置商品详情列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_list")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_list")]
                public IList<Types.GoodsDetail>? GoodsDetailList { get; set; }
            }

            public class Insurance
            {
                /// <summary>
                /// 获取或设置是否保价。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("use_insured")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("use_insured")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool UseInsured { get; set; }

                /// <summary>
                /// 获取或设置保价金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("insured_value")]
                [System.Text.Json.Serialization.JsonPropertyName("insured_value")]
                public int InsuredValue { get; set; }
            }

            public class Service
            {
                /// <summary>
                /// 获取或设置服务类型 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_type")]
                [System.Text.Json.Serialization.JsonPropertyName("service_type")]
                public int ServiceType { get; set; }

                /// <summary>
                /// 获取或设置服务类型名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_name")]
                [System.Text.Json.Serialization.JsonPropertyName("service_name")]
                public string ServiceName { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置订单来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_source")]
        [System.Text.Json.Serialization.JsonPropertyName("add_source")]
        public int Source { get; set; }

        /// <summary>
        /// 获取或设置 App 或 H5 的微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenID { get; set; }

        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递公司客户编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_id")]
        public string BusinessId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置订单标签 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagid")]
        [System.Text.Json.Serialization.JsonPropertyName("tagid")]
        public int? TagId { get; set; }

        /// <summary>
        /// 获取或设置发件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender")]
        [System.Text.Json.Serialization.JsonPropertyName("sender")]
        public Types.Sender Sender { get; set; } = new Types.Sender();

        /// <summary>
        /// 获取或设置收件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver")]
        public Types.Receiver Receiver { get; set; } = new Types.Receiver();

        /// <summary>
        /// 获取或设置包裹信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cargo")]
        [System.Text.Json.Serialization.JsonPropertyName("cargo")]
        public Types.Cargo Cargo { get; set; } = new Types.Cargo();

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop")]
        [System.Text.Json.Serialization.JsonPropertyName("shop")]
        public Types.Shop? Shop { get; set; }

        /// <summary>
        /// 获取或设置保价信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insured")]
        [System.Text.Json.Serialization.JsonPropertyName("insured")]
        public Types.Insurance Insurance { get; set; } = new Types.Insurance();

        /// <summary>
        /// 获取或设置服务类型信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service")]
        [System.Text.Json.Serialization.JsonPropertyName("service")]
        public Types.Service Service { get; set; } = new Types.Service();

        /// <summary>
        /// 获取或设置预期上门揽件时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expect_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expect_time")]
        public long? ExpectedTimestamp { get; set; }

        /// <summary>
        /// 获取或设置分单策略。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("take_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("take_mode")]
        public int? TakeMode { get; set; }
    }
}
