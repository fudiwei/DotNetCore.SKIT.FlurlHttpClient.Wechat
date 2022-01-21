namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/target/plan_info 接口的响应。</para>
    /// </summary>
    public class UnionPromoterTargetPlanInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class TargetPlan
            {
                /// <summary>
                /// 获取或设置计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planId")]
                [System.Text.Json.Serialization.JsonPropertyName("planId")]

                public string PlanId { get; set; } = default!;

                /// <summary>
                /// 获取或设置计划名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planName")]
                [System.Text.Json.Serialization.JsonPropertyName("planName")]

                public string PlanName { get; set; } = default!;

                /// <summary>
                /// 获取或设置计划描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planDesc")]
                [System.Text.Json.Serialization.JsonPropertyName("planDesc")]

                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置计划状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("planStatus")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]

                public int Status { get; set; }

                /// <summary>
                /// 获取或设置计划开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planStartTime")]
                [System.Text.Json.Serialization.JsonPropertyName("planStartTime")]

                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置计划结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planEndTime")]
                [System.Text.Json.Serialization.JsonPropertyName("planEndTime")]

                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置扩展信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("extInfo")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.DynamicObjectReadOnlyConverter))]

                public dynamic? Extra { get; set; }
            }

            public class Product
            {
                public static class Types
                {
                    public class ProductDetail
                    {
                        public static class Types
                        {
                            public class Category : UnionPromoterProductListResponse.Types.Product.Types.ProductDetail.Types.Category
                            {
                            }

                            public class Detail : UnionPromoterProductListResponse.Types.Product.Types.ProductDetail.Types.Information.Types.Detail
                            {
                            }

                            public class Parameter : UnionPromoterProductListResponse.Types.Product.Types.ProductDetail.Types.Parameter
                            {
                            }

                            public class SKU : UnionPromoterProductListResponse.Types.Product.Types.ProductDetail.Types.SKU
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]

                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品子标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subTitle")]
                        [System.Text.Json.Serialization.JsonPropertyName("subTitle")]

                        public string SubTitle { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品主图 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("headImg")]
                        [System.Text.Json.Serialization.JsonPropertyName("headImg")]

                        public string[] HeadImageUrlList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品类目列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category")]
                        [System.Text.Json.Serialization.JsonPropertyName("category")]

                        public Types.Category[] CategoryList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置品牌 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brandId")]
                        [System.Text.Json.Serialization.JsonPropertyName("brandId")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int BrandId { get; set; }

                        /// <summary>
                        /// 获取或设置品牌名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand")]
                        public string? BrandName { get; set; }

                        /// <summary>
                        /// 获取或设置型号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("model")]
                        [System.Text.Json.Serialization.JsonPropertyName("model")]
                        public string? Model { get; set; }

                        /// <summary>
                        /// 获取或设置商品详情信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail")]
                        public Types.Detail Detail { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("param")]
                        [System.Text.Json.Serialization.JsonPropertyName("param")]
                        public Types.Parameter[] ParameterList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 最低价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("minPrice")]
                        [System.Text.Json.Serialization.JsonPropertyName("minPrice")]
                        public int MinPrice { get; set; }

                        /// <summary>
                        /// 获取或设置总库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("totalStockNum")]
                        [System.Text.Json.Serialization.JsonPropertyName("totalStockNum")]
                        public int TotalStock { get; set; }

                        /// <summary>
                        /// 获取或设置总销量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("totalSoldNum")]
                        [System.Text.Json.Serialization.JsonPropertyName("totalSoldNum")]
                        public int TotalSales { get; set; }
                    }

                    public class League : UnionPromoterProductListResponse.Types.Product.Types.League
                    {
                        /// <summary>
                        /// 获取或设置是否为禁用的微信 UIN。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("banBizuin")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("banBizuin")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsBannedBusinessUIN { get; set; }

                        /// <summary>
                        /// 获取或设置是否为禁用的类目。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("banCategory")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("banCategory")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsBannedCategory { get; set; }

                        /// <summary>
                        /// 获取或设置是否为禁用的商品。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("banProduct")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("banProduct")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsBannedProduct { get; set; }
                    }

                    public class Coupon : UnionPromoterProductListResponse.Types.Product.Types.Coupon
                    {
                        /// <summary>
                        /// 获取或设置优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? Discount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("planId")]
                [System.Text.Json.Serialization.JsonPropertyName("planId")]

                public string PlanId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productId")]
                [System.Text.Json.Serialization.JsonPropertyName("productId")]

                public string ProductId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("productStatus")]

                public int ProductStatus { get; set; }

                /// <summary>
                /// 获取或设置佣金率（单位：万分之一）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commissionRatio")]
                [System.Text.Json.Serialization.JsonPropertyName("commissionRatio")]

                public int CommissionRatio { get; set; }

                /// <summary>
                /// 获取或设置商品详情信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productDetailInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("productDetailInfo")]

                public Types.ProductDetail ProductDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置联盟佣金信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("leagueExInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("leagueExInfo")]

                public Types.League League { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠券信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("couponInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("couponInfo")]

                public Types.Coupon Coupon { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置定向计划信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("targetPlanInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("targetPlanInfo")]

        public Types.TargetPlan TargetPlan { get; set; } = default!;

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productListInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("productListInfo")]

        public Types.Product[] ProductList { get; set; } = default!;
    }
}
