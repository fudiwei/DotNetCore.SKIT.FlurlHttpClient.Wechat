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
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

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
                    }

                    public class TransactionFee
                    {
                        /// <summary>
                        /// 获取或设置实收的交易佣金比例（单位：万分比）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("basis_point")]
                        [System.Text.Json.Serialization.JsonPropertyName("basis_point")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int BasisPoint { get; set; }

                        /// <summary>
                        /// 获取或设置原始佣金比例（单位：万分比）。
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
                /// 获取或设置定准类目的品牌列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_list")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_list")]
                public Types.Brand[]? BrandList { get; set; }

                /// <summary>
                /// 获取或设置保证金（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deposit")]
                [System.Text.Json.Serialization.JsonPropertyName("deposit")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? Deposit { get; set; }

                /// <summary>
                /// 获取或设置产品属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_attr_list")]
                [System.Text.Json.Serialization.JsonPropertyName("product_attr_list")]
                public Types.ProductAttribute[]? ProductAttributeList { get; set; }

                /// <summary>
                /// 获取或设置交易佣金信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transactionfee_info")]
                [System.Text.Json.Serialization.JsonPropertyName("transactionfee_info")]
                public Types.TransactionFee? TransactionFee { get; set; }

                /// <summary>
                /// 获取或设置是否品牌定向准入。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_limit_brand")]
                [System.Text.Json.Serialization.JsonPropertyName("is_limit_brand")]
                public bool IsLimitBrand { get; set; }
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
