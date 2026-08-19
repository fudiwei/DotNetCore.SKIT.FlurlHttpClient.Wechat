namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ec/category/getcategoryproductrule 接口的响应。</para>
    /// </summary>
    public class ShopECCategoryGetCategoryProductRuleResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Category
            {
                /// <summary>
                /// 获取或设置类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
                public long CategoryId { get; set; }

                /// <summary>
                /// 获取或设置类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;
            }

            public class Brand
            {
                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long BrandId { get; set; }

                /// <summary>
                /// 获取或设置品牌中文名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ch_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ch_name")]
                public string ChineseName { get; set; } = default!;

                /// <summary>
                /// 获取或设置品牌英文名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("en_name")]
                [System.Text.Json.Serialization.JsonPropertyName("en_name")]
                public string EnglishName { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否在当前类目品牌池内。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_in_category_brand_pool")]
                [System.Text.Json.Serialization.JsonPropertyName("is_in_category_brand_pool")]
                public bool IsInCategoryBrandPool { get; set; }

                /// <summary>
                /// 获取或设置是否具备该品牌资质。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_brand_authorized")]
                [System.Text.Json.Serialization.JsonPropertyName("is_brand_authorized")]
                public bool IsBrandAuthorized { get; set; } = default!;
            }

            public class RestrictedBrand
            {
                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long BrandId { get; set; }

                /// <summary>
                /// 获取或设置品牌中文名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ch_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ch_name")]
                public string ChineseName { get; set; } = default!;

                /// <summary>
                /// 获取或设置品牌英文名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("en_name")]
                [System.Text.Json.Serialization.JsonPropertyName("en_name")]
                public string EnglishName { get; set; } = default!;
            }

            public class ProductAttribute : ChannelsECCategoryDetailResponse.Types.CategoryAttribute.Types.ProductAttribute
            {
                public static class Types
                {
                    public class RequiredRule
                    {
                        public static class Types
                        {
                            public class OrCombinator
                            {
                                /// <summary>
                                /// 获取或设置规则组合列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("and_combinators")]
                                [System.Text.Json.Serialization.JsonPropertyName("and_combinators")]
                                public Types.AndCombinator[]? AndCombinatorList { get; set; }
                            }

                            public class AndCombinator
                            {
                                /// <summary>
                                /// 获取或设置组合类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("combine_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("combine_type")]
                                public int CombineType { get; set; }

                                /// <summary>
                                /// 获取或设置检查参数列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text_conditions")]
                                [System.Text.Json.Serialization.JsonPropertyName("text_conditions")]
                                public Types.TextCondition[]? TextConditionList { get; set; }
                            }

                            public class TextCondition
                            {
                                /// <summary>
                                /// 获取或设置检查的字段。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("check_field")]
                                [System.Text.Json.Serialization.JsonPropertyName("check_field")]
                                public int CheckField { get; set; } 

                                /// <summary>
                                /// 获取或设置操作类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("oper_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("oper_type")]
                                public int OperateType { get; set; }

                                /// <summary>
                                /// 获取或设置关键字列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("keywords")]
                                [System.Text.Json.Serialization.JsonPropertyName("keywords")]
                                public string[]? Keywords { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置规则类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rule_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("rule_type")]
                        public int RuleType { get; set; }

                        /// <summary>
                        /// 获取或设置规则组合列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("or_combinators")]
                        [System.Text.Json.Serialization.JsonPropertyName("or_combinators")]
                        public Types.OrCombinator[]? OrCombinatorList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置填写规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("required_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("required_rule")]
                public Types.RequiredRule? RequiredRule { get; set; }
            }

            public class SaleAttribute : ProductAttribute
            {
                public static new class Types
                {
                    public class RequiredRule : ProductAttribute.Types.RequiredRule
                    {
                    }
                }
            }

            public class ProductQualification
            {
                public static class Types
                {
                    public class RequiredRule : ProductAttribute.Types.RequiredRule
                    {
                    }
                }

                /// <summary>
                /// 获取或设置资质 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long QualificationId { get; set; }

                /// <summary>
                /// 获取或设置资质名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置资质描述信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tips")]
                [System.Text.Json.Serialization.JsonPropertyName("tips")]
                public string? Tips { get; set; }

                /// <summary>
                /// 获取或设置填写规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("required_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("required_rule")]
                public Types.RequiredRule? RequiredRule { get; set; }
            }

            public class ProductRequirement : ChannelsECCategoryDetailResponse.Types.CategoryAttribute.Types.ProductRequirement
            {
            }

            public class SizeChart : ChannelsECCategoryDetailResponse.Types.CategoryAttribute.Types.SizeChart
            {
            }

            public class ExtraService
            {
                /// <summary>
                /// 获取或设置额外服务参数名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extra_service_name")]
                [System.Text.Json.Serialization.JsonPropertyName("extra_service_name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置额外服务参数类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extra_service_type")]
                [System.Text.Json.Serialization.JsonPropertyName("extra_service_type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置额外服务参数值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extra_service_value")]
                [System.Text.Json.Serialization.JsonPropertyName("extra_service_value")]
                public string? Value { get; set; }
            }

            public class PresaleRule
            {
                public static class Types
                {
                    public class DeliveryAfterPresale
                    {
                        /// <summary>
                        /// 获取或设置预售周期最大可设置天数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("presale_cycle_span")]
                        [System.Text.Json.Serialization.JsonPropertyName("presale_cycle_span")]
                        public int? PresaleCycleSpan { get; set; }

                        /// <summary>
                        /// 获取或设置最小发货延迟天数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("min_delay_day")]
                        [System.Text.Json.Serialization.JsonPropertyName("min_delay_day")]
                        public int? MinimumDelayDays { get; set; }

                        /// <summary>
                        /// 获取或设置最大发货延迟天数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max_delay_day")]
                        [System.Text.Json.Serialization.JsonPropertyName("max_delay_day")]
                        public int? MaximumDelayDays { get; set; }
                    }

                    public class DeliveryAfterPay
                    {
                        /// <summary>
                        /// 获取或设置最小发货延迟天数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("min_delay_day")]
                        [System.Text.Json.Serialization.JsonPropertyName("min_delay_day")]
                        public int? MinimumDelayDays { get; set; }

                        /// <summary>
                        /// 获取或设置最大发货延迟天数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max_delay_day")]
                        [System.Text.Json.Serialization.JsonPropertyName("max_delay_day")]
                        public int? MaximumDelayDays { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置是否支持预售。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("presale_switch")]
                [System.Text.Json.Serialization.JsonPropertyName("presale_switch")]
                public bool IsPresaleSupported { get; set; }

                /// <summary>
                /// 获取或设置预售结束后发货规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_after_presale")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_after_presale")]
                public Types.DeliveryAfterPresale? DeliveryAfterPresale { get; set; }

                /// <summary>
                /// 获取或设置付款后发货规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_after_pay")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_after_pay")]
                public Types.DeliveryAfterPay? DeliveryAfterPay { get; set; }

                /// <summary>
                /// 获取或设置商品价格最低要求。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_price_threshold")]
                [System.Text.Json.Serialization.JsonPropertyName("product_price_threshold")]
                public string? ProductPriceThresholdString { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置类目信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.Category Category { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否为定向类目。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_directed_category")]
        [System.Text.Json.Serialization.JsonPropertyName("is_directed_category")]
        public bool? IsDirectedCategory { get; set; }

        /// <summary>
        /// 获取或设置品牌信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_info")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_info")]
        public Types.Brand? Brand { get; set; }

        /// <summary>
        /// 获取或设置类目可售品牌范围列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restricted_brand_list")]
        [System.Text.Json.Serialization.JsonPropertyName("restricted_brand_list")]
        public Types.RestrictedBrand[]? RestrictedBrandList { get; set; }

        /// <summary>
        /// 获取或设置商品属性列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_attr_list")]
        [System.Text.Json.Serialization.JsonPropertyName("product_attr_list")]
        public Types.ProductAttribute[]? ProductAttributeList { get; set; }

        /// <summary>
        /// 获取或设置销售属性列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sale_attr_list")]
        [System.Text.Json.Serialization.JsonPropertyName("sale_attr_list")]
        public Types.SaleAttribute[]? SaleAttributeList { get; set; }

        /// <summary>
        /// 获取或设置商品资质列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_qua_list")]
        [System.Text.Json.Serialization.JsonPropertyName("product_qua_list")]
        public Types.ProductQualification[]? ProductQualificationList { get; set; }

        /// <summary>
        /// 获取或设置价格下限（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("floor_price")]
        [System.Text.Json.Serialization.JsonPropertyName("floor_price")]
        public int? FloorPrice { get; set; }

        /// <summary>
        /// 获取或设置商品编辑要求信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_requirement")]
        [System.Text.Json.Serialization.JsonPropertyName("product_requirement")]
        public Types.ProductRequirement? ProductRequirement { get; set; }

        /// <summary>
        /// 获取或设置尺码表信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size_chart")]
        [System.Text.Json.Serialization.JsonPropertyName("size_chart")]
        public Types.SizeChart? SizeChart { get; set; }

        /// <summary>
        /// 获取或设置额外服务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_service_list")]
        [System.Text.Json.Serialization.JsonPropertyName("extra_service_list")]
        public Types.ExtraService[]? ExtraServiceList { get; set; }

        /// <summary>
        /// 获取或设置是否必填 SKU 条形码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_need_bar_code")]
        [System.Text.Json.Serialization.JsonPropertyName("is_need_bar_code")]
        public bool? RequireBarCode { get; set; }

        /// <summary>
        /// 获取或设置预售规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("presale_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("presale_rule")]
        public Types.PresaleRule? PresaleRule { get; set; }
    }
}
