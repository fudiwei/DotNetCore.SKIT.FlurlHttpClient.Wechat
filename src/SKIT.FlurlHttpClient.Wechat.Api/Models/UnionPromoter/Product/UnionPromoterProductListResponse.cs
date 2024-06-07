using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/product/list 接口的响应。</para>
    /// </summary>
    public class UnionPromoterProductListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class ProductDetail
                    {
                        public static class Types
                        {
                            public class Category
                            {
                                /// <summary>
                                /// 获取或设置商品类目 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("catId")]
                                [System.Text.Json.Serialization.JsonPropertyName("catId")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int CategoryId { get; set; }

                                /// <summary>
                                /// 获取或设置上级商品类目名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;
                            }

                            public class Parameter
                            {
                                /// <summary>
                                /// 获取或设置属性的 Key。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("key")]
                                [System.Text.Json.Serialization.JsonPropertyName("key")]
                                public string Key { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性的值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public string Value { get; set; } = default!;
                            }

                            public class Information
                            {
                                public static class Types
                                {
                                    public class Detail
                                    {
                                        /// <summary>
                                        /// 获取或设置商品详情图片 Url 列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("detailImg")]
                                        [System.Text.Json.Serialization.JsonPropertyName("detailImg")]
                                        public string[] ImageUrlList { get; set; } = default!;
                                    }

                                    public class Express
                                    {
                                        /// <summary>
                                        /// 获取或设置运费模板 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("templateId")]
                                        [System.Text.Json.Serialization.JsonPropertyName("templateId")]
                                        public long TemplateId { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置商品标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品副标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("subTitle")]
                                [System.Text.Json.Serialization.JsonPropertyName("subTitle")]
                                public string? SubTitle { get; set; }

                                /// <summary>
                                /// 获取或设置商品主图 URL 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("headImg")]
                                [System.Text.Json.Serialization.JsonPropertyName("headImg")]
                                public string[] HeadImageUrlList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品详情信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("detail")]
                                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                                public Types.Detail Detail { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置品牌 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("brandId")]
                                [System.Text.Json.Serialization.JsonPropertyName("brandId")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long BrandId { get; set; }

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
                                /// 获取或设置商品类目列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("category")]
                                [System.Text.Json.Serialization.JsonPropertyName("category")]
                                public Category[] CategoryList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品属性列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("param")]
                                [System.Text.Json.Serialization.JsonPropertyName("param")]
                                public Parameter[] ParameterList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置运费信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("expressInfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("expressInfo")]
                                public Types.Express Express { get; set; } = default!;

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

                                /// <summary>
                                /// 获取或设置总订单数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("totalOrderNum")]
                                [System.Text.Json.Serialization.JsonPropertyName("totalOrderNum")]
                                public int TotalOrderCount { get; set; }
                            }

                            public class SKU
                            {
                                public static class Types
                                {
                                    public class Information
                                    {
                                        public static class Types
                                        {
                                            public class Stock
                                            {
                                                /// <summary>
                                                /// 获取或设置库存量。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("stockNum")]
                                                [System.Text.Json.Serialization.JsonPropertyName("stockNum")]
                                                public int Value { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置缩略图 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("thumbImg")]
                                        [System.Text.Json.Serialization.JsonPropertyName("thumbImg")]
                                        public string ThumbnailUrl { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置售价（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("salePrice")]
                                        [System.Text.Json.Serialization.JsonPropertyName("salePrice")]
                                        public int SalePrice { get; set; }

                                        /// <summary>
                                        /// 获取或设置市场价（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("marketPrice")]
                                        [System.Text.Json.Serialization.JsonPropertyName("marketPrice")]
                                        public int MarketPrice { get; set; }

                                        /// <summary>
                                        /// 获取或设置库存信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("stockInfo")]
                                        [System.Text.Json.Serialization.JsonPropertyName("stockInfo")]
                                        public Types.Stock Stock { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置商品编码。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("skuCode")]
                                        [System.Text.Json.Serialization.JsonPropertyName("skuCode")]
                                        public string? SKUCode { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("skuId")]
                                [System.Text.Json.Serialization.JsonPropertyName("skuId")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 上线状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int? Status { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 基本信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("productSkuInfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("productSkuInfo")]
                                public Types.Information Information { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("productId")]
                        [System.Text.Json.Serialization.JsonPropertyName("productId")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置商品上线状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置商品基本信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("info")]
                        [System.Text.Json.Serialization.JsonPropertyName("info")]
                        public Types.Information Information { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("skus")]
                        public Types.SKU[] SKUList { get; set; } = default!;
                    }

                    public class League
                    {
                        /// <summary>
                        /// 获取或设置是否有佣金。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hasCommission")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("hasCommission")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool HasCommission { get; set; }

                        /// <summary>
                        /// 获取或设置佣金比例（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commissionRatio")]
                        [System.Text.Json.Serialization.JsonPropertyName("commissionRatio")]
                        public int? CommissionRatio { get; set; }

                        /// <summary>
                        /// 获取或设置佣金金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commissionValue")]
                        [System.Text.Json.Serialization.JsonPropertyName("commissionValue")]
                        public int? CommissionValue { get; set; }
                    }

                    public class Shop
                    {
                        /// <summary>
                        /// 获取或设置小商店 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appId")]
                        [System.Text.Json.Serialization.JsonPropertyName("appId")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小商店名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小商店头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("headImgUrl")]
                        [System.Text.Json.Serialization.JsonPropertyName("headImgUrl")]
                        public string HeadImageUrl { get; set; } = default!;
                    }

                    public class Coupon
                    {
                        public static class Types
                        {
                            public class CouponDetail
                            {
                                public static class Types
                                {
                                    public class Discount
                                    {
                                        public static class Types
                                        {
                                            public class DiscountCondidtion
                                            {
                                                /// <summary>
                                                /// 获取或设置商品数量。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("productCnt")]
                                                [System.Text.Json.Serialization.JsonPropertyName("productCnt")]
                                                public int? ProductCount { get; set; }

                                                /// <summary>
                                                /// 获取或设置商品 ID 列表。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("productIds")]
                                                [System.Text.Json.Serialization.JsonPropertyName("productIds")]
                                                public long[]? ProductIdList { get; set; }

                                                /// <summary>
                                                /// 获取或设置商品价格（单位：分）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("productPrice")]
                                                [System.Text.Json.Serialization.JsonPropertyName("productPrice")]
                                                public int? ProductPrice { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置优惠条件信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("discountCondition")]
                                        [System.Text.Json.Serialization.JsonPropertyName("discountCondition")]
                                        public Types.DiscountCondidtion? DiscountCondidtion { get; set; }

                                        /// <summary>
                                        /// 获取或设置满减金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("discountFee")]
                                        [System.Text.Json.Serialization.JsonPropertyName("discountFee")]
                                        public int? DiscountFee { get; set; }

                                        /// <summary>
                                        /// 获取或设置折扣数值（范围：1000～10000）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("discountNum")]
                                        [System.Text.Json.Serialization.JsonPropertyName("discountNum")]
                                        public int? DiscountNumber { get; set; }
                                    }

                                    public class Reception
                                    {
                                        /// <summary>
                                        /// 获取或设置单人限领数量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("limitNumOnePerson")]
                                        [System.Text.Json.Serialization.JsonPropertyName("limitNumOnePerson")]
                                        public int LimitPerUser { get; set; }

                                        /// <summary>
                                        /// 获取或设置领取开始时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("startTime")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("startTime")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                                        public DateTimeOffset? StartTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置领取结束时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("endTime")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("endTime")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                                        public DateTimeOffset? EndTime { get; set; }
                                    }

                                    public class Validity
                                    {
                                        /// <summary>
                                        /// 获取或设置有效期类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("validType")]
                                        [System.Text.Json.Serialization.JsonPropertyName("validType")]
                                        public string ValidType { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置相对生效天数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("validDayNum")]
                                        [System.Text.Json.Serialization.JsonPropertyName("validDayNum")]
                                        public int? ValidDays { get; set; }

                                        /// <summary>
                                        /// 获取或设置绝对生效开始时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("startTime")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("startTime")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                                        public DateTimeOffset? StartTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置绝对生效结束时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("endTime")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("endTime")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                                        public DateTimeOffset? EndTime { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置优惠券类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public int Type { get; set; }

                                /// <summary>
                                /// 获取或设置优惠券库存。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("restNum")]
                                [System.Text.Json.Serialization.JsonPropertyName("restNum")]
                                public int Stock { get; set; }

                                /// <summary>
                                /// 获取或设置优惠信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discountInfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("discountInfo")]
                                public Types.Discount Discount { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置接收信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("receiveInfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("receiveInfo")]
                                public Types.Reception? Reception { get; set; }

                                /// <summary>
                                /// 获取或设置有效期信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("validInfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("validInfo")]
                                public Types.Validity Validity { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置是否有联盟优惠券。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hasCoupon")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("hasCoupon")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool HasCoupon { get; set; }

                        /// <summary>
                        /// 获取或设置优惠券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("couponId")]
                        [System.Text.Json.Serialization.JsonPropertyName("couponId")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long? CouponId { get; set; }

                        /// <summary>
                        /// 获取或设置优惠券详细信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("couponDetail")]
                        [System.Text.Json.Serialization.JsonPropertyName("couponDetail")]
                        public Types.CouponDetail? CouponDetail { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productId")]
                [System.Text.Json.Serialization.JsonPropertyName("productId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product")]
                [System.Text.Json.Serialization.JsonPropertyName("product")]
                public Types.ProductDetail ProductDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置联盟佣金信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("leagueExInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("leagueExInfo")]
                public Types.League League { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品所属小商店信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shopInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("shopInfo")]
                public Types.Shop Shop { get; set; } = default!;

                /// <summary>
                /// 获取或设置联盟优惠券信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("couponInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("couponInfo")]
                public Types.Coupon? Coupon { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("productList")]
        [System.Text.Json.Serialization.JsonPropertyName("productList")]
        public Types.Product[] ProductList { get; set; } = default!;

        /// <summary>
        /// 获取或设置商品总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
