using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/offline/get_same_city_template 接口的响应。</para>
    /// </summary>
    public class ProductOfflineGetSameCityTemplateResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Template
            {
                public static class Types
                {
                    public class Valuation
                    {
                        public static class Types
                        {
                            public class ConditionFreeDetail
                            {
                                /// <summary>
                                /// 获取或设置最低金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("min_free_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("min_free_price")]
                                public int MinPrice { get; set; }
                            }

                            public class TieredBillingDetail
                            {
                                /// <summary>
                                /// 获取或设置最低起送金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("min_send_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("min_send_price")]
                                public int MinPrice { get; set; }

                                /// <summary>
                                /// 获取或设置首段配送范围（单位：米）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("first_val_meter")]
                                [System.Text.Json.Serialization.JsonPropertyName("first_val_meter")]
                                public int FirstValueMeter { get; set; }

                                /// <summary>
                                /// 获取或设置首段配送价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("first_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("first_price")]
                                public int FirstValuePrice { get; set; }

                                /// <summary>
                                /// 获取或设置增量配送范围（单位：米）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("second_val_meter")]
                                [System.Text.Json.Serialization.JsonPropertyName("second_val_meter")]
                                public int SecondValueMeter { get; set; }

                                /// <summary>
                                /// 获取或设置增量配送价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("second_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("second_price")]
                                public int SecondValuePrice { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置计费类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置条件免运费信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("condition_free_valuation")]
                        [System.Text.Json.Serialization.JsonPropertyName("condition_free_valuation")]
                        public Types.ConditionFreeDetail? ConditionFreeDetail { get; set; }

                        /// <summary>
                        /// 获取或设置阶梯计费信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tiered_billing_valuation")]
                        [System.Text.Json.Serialization.JsonPropertyName("tiered_billing_valuation")]
                        public Types.TieredBillingDetail? TieredBillingDetail { get; set; }
                    }

                    public class SpecialTimeValuation
                    {
                        public static class Types
                        {
                            public class ExtraBillingDetail
                            {
                                /// <summary>
                                /// 获取或设置开始时间的小时。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start_hour")]
                                [System.Text.Json.Serialization.JsonPropertyName("start_hour")]
                                public int StartHour { get; set; }

                                /// <summary>
                                /// 获取或设置开始时间的分钟。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start_minute")]
                                [System.Text.Json.Serialization.JsonPropertyName("start_minute")]
                                public int StartMinute { get; set; }

                                /// <summary>
                                /// 获取或设置结束时间的小时。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_hour")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_hour")]
                                public int EndHour { get; set; }

                                /// <summary>
                                /// 获取或设置结束时间的分钟。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_minute")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_minute")]
                                public int EndMinute { get; set; }

                                /// <summary>
                                /// 获取或设置配送价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("fee")]
                                public int Price { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置计费类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置额外计费信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("extra_fee_valuation")]
                        [System.Text.Json.Serialization.JsonPropertyName("extra_fee_valuation")]
                        public Types.ExtraBillingDetail? ExtraBillingDetail { get; set; }
                    }

                    public class DeliveryTime
                    {
                        /// <summary>
                        /// 获取或设置开店时间的小时。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_business_hour")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_business_hour")]
                        public int StartBusinessHour { get; set; }

                        /// <summary>
                        /// 获取或设置开店时间的分钟。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_business_minute")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_business_minute")]
                        public int StartBusinessMinute { get; set; }

                        /// <summary>
                        /// 获取或设置关店时间的小时。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_business_hour")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_business_hour")]
                        public int EndBusinessHour { get; set; }

                        /// <summary>
                        /// 获取或设置关店时间的分钟。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_business_minute")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_business_minute")]
                        public int EndBusinessMinute { get; set; }

                        /// <summary>
                        /// 获取或设置可预定时间（单位：分钟）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("book_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("book_time")]
                        public int BookTime { get; set; }

                        /// <summary>
                        /// 获取或设置首段送达范围（单位：米）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_val_meter")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_val_meter")]
                        public int FirstValueMeter { get; set; }

                        /// <summary>
                        /// 获取或设置首段送达时间（单位：分钟）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_val_minutes")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_val_minutes")]
                        public int FirstValueTime { get; set; }

                        /// <summary>
                        /// 获取或设置增量送达范围（单位：米）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_val_meter")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_val_meter")]
                        public int SecondValueMeter { get; set; }

                        /// <summary>
                        /// 获取或设置增量送达时间（单位：分钟）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_val_minutes")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_val_minutes")]
                        public int SecondValueTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public int TemplateId { get; set; }

                /// <summary>
                /// 获取或设置配送方。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipper")]
                [System.Text.Json.Serialization.JsonPropertyName("shipper")]
                public string Shipper { get; set; } = default!;

                /// <summary>
                /// 获取或设置配送范围（单位：米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scope")]
                [System.Text.Json.Serialization.JsonPropertyName("scope")]
                public int Scope { get; set; }

                /// <summary>
                /// 获取或设置计价方式信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("same_city_valuation")]
                [System.Text.Json.Serialization.JsonPropertyName("same_city_valuation")]
                public Types.Valuation Valuation { get; set; } = default!;

                /// <summary>
                /// 获取或设置特殊时段计价方式信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("special_time")]
                [System.Text.Json.Serialization.JsonPropertyName("special_time")]
                public Types.SpecialTimeValuation SpecialTimeValuation { get; set; } = default!;

                /// <summary>
                /// 获取或设置配送时间信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_time")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_time")]
                public Types.DeliveryTime DeliveryTime { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置同城配送模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("same_city_template")]
        [System.Text.Json.Serialization.JsonPropertyName("same_city_template")]
        public Types.Template Template { get; set; } = default!;
    }
}
