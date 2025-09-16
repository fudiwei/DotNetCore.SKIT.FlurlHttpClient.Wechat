using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/paytool/open_order 接口的请求。</para>
    /// </summary>
    public class CgibinPayToolOpenOrderRequest : CgibinPayToolOrderRequestBase
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class ProductBase
                    {
                        /// <summary>
                        /// 获取或设置购买类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                        public int OrderType { get; set; }

                        /// <summary>
                        /// 获取或设置是否推送确认提醒。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("notify_custom_corp")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("notify_custom_corp")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool? IsNotifyCustomCorp { get; set; }
                    }

                    public class ThirdPartyApp : ProductBase
                    {
                        public static class Types
                        {
                            public class BuyInfo
                            {
                                public static class Types
                                {
                                    public class DiscountInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置优惠类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("discount_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("discount_type")]
                                        public int DiscountType { get; set; }

                                        /// <summary>
                                        /// 获取或设置优惠金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("discount_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
                                        public int? DiscountAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置优惠折扣（单位：百分数）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("discount_ratio")]
                                        [System.Text.Json.Serialization.JsonPropertyName("discount_ratio")]
                                        public int? DiscountRatio { get; set; }

                                        /// <summary>
                                        /// 获取或设置优惠原因。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("discount_remarks")]
                                        [System.Text.Json.Serialization.JsonPropertyName("discount_remarks")]
                                        public string? DiscountRemarks { get; set; }
                                    }   
                                }

                                /// <summary>
                                /// 获取或设置套件 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("suiteid")]
                                [System.Text.Json.Serialization.JsonPropertyName("suiteid")]
                                public string SuiteId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置旧版应用 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                                public int? AppId { get; set; }

                                /// <summary>
                                /// 获取或设置版本号 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("edition_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("edition_id")]
                                public string EditionId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置购买人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_count")]
                                public int? UserCount { get; set; }

                                /// <summary>
                                /// 获取或设置购买天数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("duration_days")]
                                [System.Text.Json.Serialization.JsonPropertyName("duration_days")]
                                public int? DurationDays { get; set; }

                                /// <summary>
                                /// 获取或设置生效日期字符串（格式：yyyyMMdd）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("take_effect_date")]
                                [System.Text.Json.Serialization.JsonPropertyName("take_effect_date")]
                                public string? TakeEffectDateString { get; set; }

                                /// <summary>
                                /// 获取或设置优惠信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discount_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("discount_info")]
                                public Types.DiscountInfo? DiscountInfo { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置购买应用列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buy_info_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("buy_info_list")]
                        public IList<Types.BuyInfo> BuyInfoList { get; set; } = new List<Types.BuyInfo>();
                    }

                    public class CustomizedApp : ProductBase
                    {
                        public static class Types
                        {
                            public class BuyInfo
                            {
                                /// <summary>
                                /// 获取或设置套件 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("suiteid")]
                                [System.Text.Json.Serialization.JsonPropertyName("suiteid")]
                                public string SuiteId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置旧版应用 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                                public int? AppId { get; set; }

                                /// <summary>
                                /// 获取或设置购买人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_count")]
                                public int? UserCount { get; set; }

                                /// <summary>
                                /// 获取或设置购买天数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("duration_days")]
                                [System.Text.Json.Serialization.JsonPropertyName("duration_days")]
                                public int? DurationDays { get; set; }

                                /// <summary>
                                /// 获取或设置生效日期字符串（格式：yyyyMMdd）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("take_effect_date")]
                                [System.Text.Json.Serialization.JsonPropertyName("take_effect_date")]
                                public string? TakeEffectDateString { get; set; }

                                /// <summary>
                                /// 获取或设置总价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_price")]
                                public int TotalPrice { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置购买应用列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buy_info_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("buy_info_list")]
                        public IList<Types.BuyInfo> BuyInfoList { get; set; } = new List<Types.BuyInfo>();
                    }

                    public class PromotionCase : ProductBase
                    {
                        public static class Types
                        {
                            public class BuyInfo
                            {
                                /// <summary>
                                /// 获取或设置套件 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("suiteid")]
                                [System.Text.Json.Serialization.JsonPropertyName("suiteid")]
                                public string SuiteId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置旧版应用 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                                public int? AppId { get; set; }

                                /// <summary>
                                /// 获取或设置购买人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_count")]
                                public int? UserCount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置行业方案 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("case_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("case_id")]
                        public string CaseId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置行业方案版本名称
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_edition_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_edition_name")]
                        public string PromotionEditionName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置购买天数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("duration_days")]
                        [System.Text.Json.Serialization.JsonPropertyName("duration_days")]
                        public int? DurationDays { get; set; }

                        /// <summary>
                        /// 获取或设置生效日期字符串（格式：yyyyMMdd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("take_effect_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("take_effect_date")]
                        public string? TakeEffectDateString { get; set; }

                        /// <summary>
                        /// 获取或设置购买应用列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buy_info_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("buy_info_list")]
                        public IList<Types.BuyInfo>? BuyInfoList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置第三方应用商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_app")]
                [System.Text.Json.Serialization.JsonPropertyName("third_app")]
                public Types.ThirdPartyApp? ThirdPartyApp { get; set; }

                /// <summary>
                /// 获取或设置代开发应用商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customized_app")]
                [System.Text.Json.Serialization.JsonPropertyName("customized_app")]
                public Types.CustomizedApp? CustomizedApp { get; set; }

                /// <summary>
                /// 获取或设置行业解决方案商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_case")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_case")]
                public Types.PromotionCase? PromotionCase { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        public int BusinessType { get; set; }

        /// <summary>
        /// 获取或设置客户企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_corpid")]
        public string? CustomCorpId { get; set; }

        /// <summary>
        /// 获取或设置支付方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_type")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
        public int PayType { get; set; }

        /// <summary>
        /// 获取或设置服务商订单费用凭证 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_receipt_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_receipt_media_id")]
        public string? BandReceiptMediaId { get; set; }

        /// <summary>
        /// 获取或设置订单创建人成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator")]
        [System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? CreatorUserId { get; set; }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_list")]
        [System.Text.Json.Serialization.JsonPropertyName("product_list")]
        public Types.Product Product { get; set; } = new Types.Product();
    }
}
