using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/category/detail 接口的响应。</para>
    /// </summary>
    public class ChannelsECCategoryDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CategoryInfo
            {
                /// <summary>
                /// 获取或设置类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int CategoryId { get; set; }

                /// <summary>
                /// 获取或设置类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;
            }

            public class CategoryAttribute
            {
                public static class Types
                {
                    public class Brand
                    {
                        /// <summary>
                        /// 获取或设置品牌 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long BrandId { get; set; }
                    }

                    public class ProductAttribute
                    {
                        /// <summary>
                        /// 获取或设置属性名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性类型。
                        /// </summary>
                        [Obsolete("相关接口或字段于 2023-06-03 下线。")]
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置新版属性类型（后续将替代 <see cref="Type"/> 字段）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type_v2")]
                        [System.Text.Json.Serialization.JsonPropertyName("type_v2")]
                        public string TypeV2 { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否必填。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_required")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_required")]
                        public bool IsRequired { get; set; }

                        /// <summary>
                        /// 获取或设置输入提示。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hint")]
                        [System.Text.Json.Serialization.JsonPropertyName("hint")]
                        public string? Hint { get; set; }

                        /// <summary>
                        /// 获取或设置是否允许添加选项。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("append_allowed")]
                        [System.Text.Json.Serialization.JsonPropertyName("append_allowed")]
                        public bool? IsAppendAllowed { get; set; }
                    }

                    public class SaleAttribute : ProductAttribute
                    {
                    }

                    public class TransactionFee
                    {
                        /// <summary>
                        /// 获取或设置实收的交易佣金比例（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("basis_point")]
                        [System.Text.Json.Serialization.JsonPropertyName("basis_point")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int BasisPoint { get; set; }

                        /// <summary>
                        /// 获取或设置原始佣金比例（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("original_basis_point")]
                        [System.Text.Json.Serialization.JsonPropertyName("original_basis_point")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int OriginalBasisPoint { get; set; }

                        /// <summary>
                        /// 获取或设置佣金激励类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("incentive_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("incentive_type")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int IncentiveType { get; set; }
                    }

                    public class CouponRule
                    {
                        /// <summary>
                        /// 获取或设置最高的折扣比例（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_ratio_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_ratio_limit")]
                        public int DiscountRatioLimit { get; set; }

                        /// <summary>
                        /// 获取或设置最高的折扣金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_limit")]
                        public int DiscountLimit { get; set; }
                    }

                    public class ProductRequirement
                    {
                        /// <summary>
                        /// 获取或设置商品标题的编辑要求。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_title_requirement")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_title_requirement")]
                        public string? RroductTitleRequirement { get; set; }

                        /// <summary>
                        /// 获取或设置商品图片的编辑要求。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_img_requirement")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_img_requirement")]
                        public string? RroductImageRequirement { get; set; }

                        /// <summary>
                        /// 获取或设置商品描述的编辑要求。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_desc_requirement")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_desc_requirement")]
                        public string? RroductDescriptionRequirement { get; set; }
                    }

                    public class SizeChart
                    {
                        public static class Types
                        {
                            public class Item
                            {
                                /// <summary>
                                /// 获取或设置名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置单位。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("unit")]
                                [System.Text.Json.Serialization.JsonPropertyName("unit")]
                                public string Unit { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值的类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值的填写格式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("format")]
                                [System.Text.Json.Serialization.JsonPropertyName("format")]
                                public string Format { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值的限制。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("limit")]
                                [System.Text.Json.Serialization.JsonPropertyName("limit")]
                                public string Limit { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置是否必填。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_required")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_required")]
                                public bool IsRequired { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置是否支持。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_support")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_support")]
                        public bool IsSupported { get; set; }

                        /// <summary>
                        /// 获取或设置尺码项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_list")]
                        public Types.Item[]? ItemList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_no_shipment")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_no_shipment")]
                public bool IsShopNoShipmentSupported { get; set; }

                /// <summary>
                /// 获取或设置是否定向准入。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("access_permit_required")]
                [System.Text.Json.Serialization.JsonPropertyName("access_permit_required")]
                public bool IsAccessPermitRequired { get; set; }

                /// <summary>
                /// 获取或设置是否支持预售。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pre_sale")]
                [System.Text.Json.Serialization.JsonPropertyName("pre_sale")]
                public bool IsPresaleSupported { get; set; }

                /// <summary>
                /// 获取或设置是否支持七天无理由退货。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seven_day_return")]
                [System.Text.Json.Serialization.JsonPropertyName("seven_day_return")]
                public bool IsSevenDayReturnSupported { get; set; }

                /// <summary>
                /// 获取或设置是否品牌定向准入。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_limit_brand")]
                [System.Text.Json.Serialization.JsonPropertyName("is_limit_brand")]
                public bool IsLimitBrand { get; set; }

                /// <summary>
                /// 获取或设置定准类目的品牌列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_list")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_list")]
                public Types.Brand[]? BrandList { get; set; }

                /// <summary>
                /// 获取或设置产品属性列表。
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
                /// 获取或设置交易佣金信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transactionfee_info")]
                [System.Text.Json.Serialization.JsonPropertyName("transactionfee_info")]
                public Types.TransactionFee? TransactionFee { get; set; }

                /// <summary>
                /// 获取或设置优惠券规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_rule")]
                public Types.CouponRule? CouponRule { get; set; }

                /// <summary>
                /// 获取或设置保证金（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deposit")]
                [System.Text.Json.Serialization.JsonPropertyName("deposit")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? Deposit { get; set; }

                /// <summary>
                /// 获取或设置价格下限（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("floor_price")]
                [System.Text.Json.Serialization.JsonPropertyName("floor_price")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? FloorPrice { get; set; }

                /// <summary>
                /// 获取或设置商品编辑要求信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_requirement")]
                [System.Text.Json.Serialization.JsonPropertyName("product_requirement")]
                public Types.ProductRequirement? ProductRequirement { get; set; }
            }

            public class Qualification : ChannelsECCategoryAllResponse.Types.Category.Types.CategoryAndQualification.Types.Qualification
            {
            }
        }

        /// <summary>
        /// 获取或设置类目信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.CategoryInfo CategoryInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置类目属性信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attr")]
        [System.Text.Json.Serialization.JsonPropertyName("attr")]
        public Types.CategoryAttribute CategoryAttribute { get; set; } = default!;

        /// <summary>
        /// 获取或设置商品资质列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_qua_list")]
        [System.Text.Json.Serialization.JsonPropertyName("product_qua_list")]
        public Types.Qualification[]? ProductQualificationList { get; set; }
    }
}
