using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductAddRequest : WechatApiRequest, IInferable<ChannelsECProductAddRequest, ChannelsECProductAddResponse>
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
                public IList<string> ImageUrlList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置商品详情文字。
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
                public int CategoryId { get; set; }
            }

            public class Attribute
            {
                /// <summary>
                /// 获取或设置属性的 Key。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attr_key")]
                [System.Text.Json.Serialization.JsonPropertyName("attr_key")]
                public string Key { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置属性的值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attr_value")]
                [System.Text.Json.Serialization.JsonPropertyName("attr_value")]
                public string Value { get; set; } = string.Empty;
            }

            public class Express
            {
                /// <summary>
                /// 获取或设置运费模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public long TemplateId { get; set; }
            }

            public class SKU
            {
                /// <summary>
                /// 获取或设置商家自定义 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                public string OutSKUId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置缩略图 Url。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thumb_img")]
                [System.Text.Json.Serialization.JsonPropertyName("thumb_img")]
                public string ThumbnailUrl { get; set; } = string.Empty;

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
                public IList<Attribute>? AttributeList { get; set; }

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
                [Newtonsoft.Json.JsonProperty("pay_after_use")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("pay_after_use")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsPayAfterUseSupported { get; set; }

                /// <summary>
                /// 获取或设置是否支持运费险。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("freight_insurance")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("freight_insurance")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsFreightInsuranceSupported { get; set; }
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
        }

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
        public string Title { get; set; } = string.Empty;

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
        public IList<string> HeadImageUrlList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置商品详情信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc_info")]
        [System.Text.Json.Serialization.JsonPropertyName("desc_info")]
        public Types.Detail Detail { get; set; } = new Types.Detail();

        /// <summary>
        /// 获取或设置商品类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cats")]
        [System.Text.Json.Serialization.JsonPropertyName("cats")]
        public IList<Types.Category> CategoryList { get; set; } = new List<Types.Category>();

        /// <summary>
        /// 获取或设置商品属性列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attrs")]
        [System.Text.Json.Serialization.JsonPropertyName("attrs")]
        public IList<Types.Attribute>? AttributeList { get; set; }

        /// <summary>
        /// 获取或设置商品编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_code")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_code")]
        public string? ApuCode { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long? BrandId { get; set; }

        /// <summary>
        /// 获取或设置特殊资质图片媒体文件标识 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualifications")]
        [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
        public IList<string>? QualificationPictureMediaIdList { get; set; }

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
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skus")]
        [System.Text.Json.Serialization.JsonPropertyName("skus")]
        public IList<Types.SKU>? SKUList { get; set; }

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
        /// 获取或设置更新后是否立即上架。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("listing")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("listing")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? RequireListing { get; set; }

        /// <summary>
        /// 获取或设置售后地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_info")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_info")]
        public Types.Aftersale? Aftersale { get; set; }
    }
}
