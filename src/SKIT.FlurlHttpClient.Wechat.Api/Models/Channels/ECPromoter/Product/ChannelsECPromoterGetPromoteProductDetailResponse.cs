namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_promote_product_detail 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetPromoteProductDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class ProductInfo
                    {
                        public static class Types
                        {
                            public class Detail : ChannelsECProductGetResponse.Types.Product.Types.Detail
                            {
                            }

                            public class Category : ChannelsECProductGetResponse.Types.Product.Types.Category
                            {
                            }

                            public class Attribute : ChannelsECProductGetResponse.Types.Product.Types.Attribute
                            {
                            }

                            public class SKUDeliver : ChannelsECProductGetResponse.Types.Product.Types.SKUDeliverInfo
                            {
                            }

                            public class SKU
                            {
                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置缩略图 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("thumb_img")]
                                [System.Text.Json.Serialization.JsonPropertyName("thumb_img")]
                                public string ThumbnailUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置售价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sale_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("sale_price")]
                                public int SalePrice { get; set; }

                                /// <summary>
                                /// 获取或设置库存。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("stock_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("stock_num")]
                                public int Stock { get; set; }

                                /// <summary>
                                /// 获取或设置商品属性列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_attrs")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_attrs")]
                                public Attribute[]? AttributeList { get; set; }

                                /// <summary>
                                /// 获取或设置商品配送信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_deliver_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_deliver_info")]
                                public SKUDeliver? SKUDeliver { get; set; }
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
                        [Newtonsoft.Json.JsonProperty("sub_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_title")]
                        public string? SubTitle { get; set; }

                        /// <summary>
                        /// 获取或设置主图 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("head_imgs")]
                        [System.Text.Json.Serialization.JsonPropertyName("head_imgs")]
                        public string[] HeadImageUrlList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品详情信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc_info")]
                        public Types.Detail Detail { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置新版商品类目列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cats_v2")]
                        [System.Text.Json.Serialization.JsonPropertyName("cats_v2")]
                        public Types.Category[]? CategoryV2List { get; set; }

                        /// <summary>
                        /// 获取或设置商品状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("skus")]
                        public Types.SKU[] SKUs { get; set; } = default!;
                    }

                    public class CommissionInfo
                    {
                        /// <summary>
                        /// 获取或设置商品带货状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置服务费率（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_ratio")]
                        public int ServiceRatio { get; set; }

                        /// <summary>
                        /// 获取或设置合作开始时间戳戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                        public long StartTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置合作结束时间戳戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long EndTimestamp { get; set; }
                    }

                    public class HeadSupplierInfo
                    {
                        /// <summary>
                        /// 获取或设置供货机构 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("head_supplier_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("head_supplier_appid")]
                        public string HeadSupplierAppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置供货机构名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
                public string ShopAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品小程序跳转小店场景添加商品时传递的推广信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_promotion_link")]
                [System.Text.Json.Serialization.JsonPropertyName("product_promotion_link")]
                public string ProductPromotionLink { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_info")]
                [System.Text.Json.Serialization.JsonPropertyName("product_info")]
                public Types.ProductInfo ProductInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置佣金信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commission_info")]
                [System.Text.Json.Serialization.JsonPropertyName("commission_info")]
                public Types.CommissionInfo CommissionInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置供货机构信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_supplier_info")]
                [System.Text.Json.Serialization.JsonPropertyName("head_supplier_info")]
                public Types.HeadSupplierInfo? HeadSupplierInfo { get; set; }
            }

            public class Coupon
            {
                /// <summary>
                /// 获取或设置券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long CouponId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product Product { get; set; } = default!;

        /// <summary>
        /// 获取或设置商品可用的公开机构券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("public_coupons")]
        [System.Text.Json.Serialization.JsonPropertyName("public_coupons")]
        public Types.Coupon[]? PublicCouponList { get; set; }

        /// <summary>
        /// 获取或设置商品可用的定向机构券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cooperative_coupons")]
        [System.Text.Json.Serialization.JsonPropertyName("cooperative_coupons")]
        public Types.Coupon[]? CooperativeCouponList { get; set; }
    }
}
