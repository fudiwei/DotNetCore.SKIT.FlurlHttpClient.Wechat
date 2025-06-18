using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class Detail
                    {
                        /// <summary>
                        /// 获取或设置商品详情图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("imgs")]
                        [System.Text.Json.Serialization.JsonPropertyName("imgs")]
                        public string[] ImageUrlList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品文字描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string? Description { get; set; }
                    }

                    public class Category
                    {
                        /// <summary>
                        /// 获取或设置商品类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cat_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long CategoryId { get; set; }
                    }

                    public class Attribute
                    {
                        /// <summary>
                        /// 获取或设置属性的 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attr_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("attr_key")]
                        public string Key { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性的值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attr_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("attr_value")]
                        public string Value { get; set; } = default!;
                    }

                    public class Express
                    {
                        /// <summary>
                        /// 获取或设置运费模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long TemplateId { get; set; }

                        /// <summary>
                        /// 获取或设置商品重量（单位：克）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("weight")]
                        [System.Text.Json.Serialization.JsonPropertyName("weight")]
                        public int? Weight { get; set; }
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
                        /// 获取或设置商家自定义 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                        public string? OutSKUId { get; set; }

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
                        /// 获取或设置市场价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("market_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("market_price")]
                        public int MarketPrice { get; set; }

                        /// <summary>
                        /// 获取或设置库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock_num")]
                        public int Stock { get; set; }

                        /// <summary>
                        /// 获取或设置商品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_code")]
                        public string? SKUCode { get; set; }

                        /// <summary>
                        /// 获取或设置商品属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_attrs")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_attrs")]
                        public Attribute[]? AttributeList { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置商品配送信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_deliver_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_deliver_info")]
                        public SKUDeliver? SKUDeliver { get; set; }
                    }

                    public class SKUDeliver
                    {
                        /// <summary>
                        /// 获取或设置 SKU 库存情况。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock_type")]
                        public int StockType { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 发货节点。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("full_payment_presale_delivery_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("full_payment_presale_delivery_type")]
                        public int FullPaymentPresaleDeliveryType { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 预售周期开始时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("presale_begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("presale_begin_time")]
                        public long PresaleBeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 预售周期结束时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("presale_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("presale_end_time")]
                        public long PresaleEndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 发货时效。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("full_payment_presale_delivery_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("full_payment_presale_delivery_time")]
                        public int FullPaymentPresaleDeliveryTime { get; set; }
                    }

                    public class Limitation
                    {
                        /// <summary>
                        /// 获取或设置限购周期类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("period_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("period_type")]
                        public int PeriodType { get; set; }

                        /// <summary>
                        /// 获取或设置限购数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("limited_buy_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("limited_buy_num")]
                        public int? LimitedBuyCount { get; set; }
                    }

                    public class ExtraService
                    {
                        /// <summary>
                        /// 获取或设置是否支持七天无理由退货。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seven_day_return")]
                        [System.Text.Json.Serialization.JsonPropertyName("seven_day_return")]
                        public int SevenDayReturn { get; set; }

                        /// <summary>
                        /// 获取或设置先用后付类型。
                        /// </summary>
                        [Obsolete("相关接口或字段于 2024-08-05 下线。")]
                        [Newtonsoft.Json.JsonProperty("pay_after_use")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_after_use")]
                        public int PayAfterUse { get; set; }

                        /// <summary>
                        /// 获取或设置是否支持运费险。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("freight_insurance")]
                        [System.Text.Json.Serialization.JsonPropertyName("freight_insurance")]
                        public int FreightInsurance { get; set; }

                        /// <summary>
                        /// 获取或设置是否支持假一赔三。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fake_one_pay_three")]
                        [System.Text.Json.Serialization.JsonPropertyName("fake_one_pay_three")]
                        public int? FakeOnePayThree { get; set; }

                        /// <summary>
                        /// 获取或设置是否支持坏损包退。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("damage_guarantee")]
                        [System.Text.Json.Serialization.JsonPropertyName("damage_guarantee")]
                        public int? DamageGuarantee { get; set; }
                    }

                    public class Aftersale
                    {
                        /// <summary>
                        /// 获取或设置地址 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("after_sale_address_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("after_sale_address_id")]
                        public long? AftersaleAddressId { get; set; }
                    }

                    public class Qualification
                    {
                        /// <summary>
                        /// 获取或设置资质 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qua_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("qua_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long QualificationId { get; set; }

                        /// <summary>
                        /// 获取或设置资质图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qua_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("qua_url")]
                        public string[] PictureUrlList { get; set; } = default!;
                    }

                    public class SizeChart
                    {
                        public static class Types
                        {
                            public class Specification
                            {
                                public static class Types
                                {
                                    public class SpecificationValue
                                    {
                                        /// <summary>
                                        /// 获取或设置尺码值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("key")]
                                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                                        public string Key { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置属性值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                                        public string? Value { get; set; }

                                        /// <summary>
                                        /// 获取或设置属性值的左边界。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("left")]
                                        [System.Text.Json.Serialization.JsonPropertyName("left")]
                                        public string? Left { get; set; }

                                        /// <summary>
                                        /// 获取或设置属性值的右边界。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("right")]
                                        [System.Text.Json.Serialization.JsonPropertyName("right")]
                                        public string? Right { get; set; }
                                    }
                                }

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
                                /// 获取或设置属性值是否为区间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_range")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_range")]
                                public bool IsRange { get; set; }

                                /// <summary>
                                /// 获取或设置属性值映射列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_list")]
                                public Types.SpecificationValue[] ValueList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置是否启用。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enable")]
                        [System.Text.Json.Serialization.JsonPropertyName("enable")]
                        public bool IsEnabled { get; set; }

                        /// <summary>
                        /// 获取或设置尺码规格列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("specification_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("specification_list")]
                        public Types.Specification[]? SpecificationList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                public string? OutProductId { get; set; }

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
                /// 获取或设置商品类目列表。
                /// </summary>
                [Obsolete("相关接口或字段于 2024-10-28 下线。")]
                [Newtonsoft.Json.JsonProperty("cats")]
                [System.Text.Json.Serialization.JsonPropertyName("cats")]
                public Types.Category[]? CategoryList { get; set; }

                /// <summary>
                /// 获取或设置新版商品类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cats_v2")]
                [System.Text.Json.Serialization.JsonPropertyName("cats_v2")]
                public Types.Category[]? CategoryV2List { get; set; }

                /// <summary>
                /// 获取或设置商品属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attrs")]
                [System.Text.Json.Serialization.JsonPropertyName("attrs")]
                public Types.Attribute[]? AttributeList { get; set; }

                /// <summary>
                /// 获取或设置商品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_code")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_code")]
                public string? SPUCode { get; set; }

                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? BrandId { get; set; }

                /// <summary>
                /// 获取或设置发货方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deliver_method")]
                [System.Text.Json.Serialization.JsonPropertyName("deliver_method")]
                public int? DeliverMethod { get; set; }

                /// <summary>
                /// 获取或设置运费信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("express_info")]
                [System.Text.Json.Serialization.JsonPropertyName("express_info")]
                public Types.Express? Express { get; set; }

                /// <summary>
                /// 获取或设置售后说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aftersale_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("aftersale_desc")]
                public string? AftersaleDescription { get; set; }

                /// <summary>
                /// 获取或设置商品状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置商品草稿状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("edit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("edit_status")]
                public int EditingStatus { get; set; }

                /// <summary>
                /// 获取或设置 SKU 最低价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("min_price")]
                [System.Text.Json.Serialization.JsonPropertyName("min_price")]
                public int MinPrice { get; set; }

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public Types.SKU[]? SKUList { get; set; }

                /// <summary>
                /// 获取或设置限购信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limited_info")]
                [System.Text.Json.Serialization.JsonPropertyName("limited_info")]
                public Types.Limitation? Limitation { get; set; }

                /// <summary>
                /// 获取或设置额外的服务信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extra_service")]
                [System.Text.Json.Serialization.JsonPropertyName("extra_service")]
                public Types.ExtraService? ExtraService { get; set; }

                /// <summary>
                /// 获取或设置商品类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_type")]
                [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                public int? ProductType { get; set; }

                /// <summary>
                /// 获取或设置商品草稿最近一次修改时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("edit_time")]
                [System.Text.Json.Serialization.JsonPropertyName("edit_time")]
                public long EditTimestamp { get; set; }

                /// <summary>
                /// 获取或设置导入的来源商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("src_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("src_product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? SourceProductId { get; set; }

                /// <summary>
                /// 获取或设置售后地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("after_sale_info")]
                [System.Text.Json.Serialization.JsonPropertyName("after_sale_info")]
                public Types.Aftersale? Aftersale { get; set; }

                /// <summary>
                /// 获取或设置商品资质列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_qua_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("product_qua_infos")]
                public Types.Qualification[]? QualificationList { get; set; }

                /// <summary>
                /// 获取或设置尺码表信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size_chart")]
                [System.Text.Json.Serialization.JsonPropertyName("size_chart")]
                public Types.SizeChart? SizeChart { get; set; }
            }

            public class SaleLimitInfo
            {
                /// <summary>
                /// 获取或设置是否受到管控。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_limited")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_limited")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsLimited { get; set; }

                /// <summary>
                /// 获取或设置售卖限制标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置售卖限制描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_title")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_title")]
                public string? SubTitle { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置线上商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product? Product { get; set; }

        /// <summary>
        /// 获取或设置草稿商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("edit_product")]
        [System.Text.Json.Serialization.JsonPropertyName("edit_product")]
        public Types.Product? EditingProduct { get; set; }

        /// <summary>
        /// 获取或设置当日售卖上限提醒信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sale_limit_info")]
        [System.Text.Json.Serialization.JsonPropertyName("sale_limit_info")]
        public Types.SaleLimitInfo? SaleLimitInfo { get; set; }
    }
}
