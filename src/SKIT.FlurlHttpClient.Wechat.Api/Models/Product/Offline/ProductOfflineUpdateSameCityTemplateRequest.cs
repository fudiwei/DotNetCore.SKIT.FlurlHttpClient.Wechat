namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/offline/update_same_city_template 接口的请求。</para>
    /// </summary>
    public class ProductOfflineUpdateSameCityTemplateRequest : WechatApiRequest, IMapResponse<ProductOfflineUpdateSameCityTemplateRequest, ProductOfflineUpdateSameCityTemplateResponse>
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
                            public class ConditionFreeDetail : ProductOfflineGetSameCityTemplateResponse.Types.Template.Types.Valuation.Types.ConditionFreeDetail
                            {
                            }

                            public class TieredBillingDetail : ProductOfflineGetSameCityTemplateResponse.Types.Template.Types.Valuation.Types.TieredBillingDetail
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置计费类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

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
                            public class ExtraBillingDetail : ProductOfflineGetSameCityTemplateResponse.Types.Template.Types.SpecialTimeValuation.Types.ExtraBillingDetail
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置计费类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置额外计费信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("extra_fee_valuation")]
                        [System.Text.Json.Serialization.JsonPropertyName("extra_fee_valuation")]
                        public Types.ExtraBillingDetail? ExtraBillingDetail { get; set; }
                    }

                    public class DeliveryTime : ProductOfflineGetSameCityTemplateResponse.Types.Template.Types.DeliveryTime
                    {
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
                public int Shipper { get; set; }

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
                public Types.Valuation Valuation { get; set; } = new Types.Valuation();

                /// <summary>
                /// 获取或设置特殊时段计价方式信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("special_time")]
                [System.Text.Json.Serialization.JsonPropertyName("special_time")]
                public Types.SpecialTimeValuation SpecialTimeValuation { get; set; } = new Types.SpecialTimeValuation();

                /// <summary>
                /// 获取或设置配送时间信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_time")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_time")]
                public Types.DeliveryTime DeliveryTime { get; set; } = new Types.DeliveryTime();
            }
        }

        /// <summary>
        /// 获取或设置同城配送模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("same_city_template")]
        [System.Text.Json.Serialization.JsonPropertyName("same_city_template")]
        public Types.Template Template { get; set; } = new Types.Template();
    }
}
