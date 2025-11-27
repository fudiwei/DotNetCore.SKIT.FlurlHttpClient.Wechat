using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductUpdateRequest : WechatApiRequest, IInferable<ChannelsECProductUpdateRequest, ChannelsECProductUpdateResponse>
    {
        public static class Types
        {
            public class Detail : ChannelsECProductAddRequest.Types.Detail
            {
            }

            public class Category : ChannelsECProductAddRequest.Types.Category
            {
            }

            public class Attribute : ChannelsECProductAddRequest.Types.Attribute
            {
            }

            public class Express : ChannelsECProductAddRequest.Types.Express
            {
            }

            public class SKU
            {
                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                public long? SKUId { get; set; }

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
                public int? Stock { get; set; }

                /// <summary>
                /// 获取或设置商品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_code")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_code")]
                public string? SKUCode { get; set; }

                /// <summary>
                /// 获取或设置商品条形码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bar_code")]
                [System.Text.Json.Serialization.JsonPropertyName("bar_code")]
                public string? BarCode { get; set; }

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

            public class SKUDeliver : ChannelsECProductAddRequest.Types.SKUDeliver
            {
            }

            public class Limitation : ChannelsECProductAddRequest.Types.Limitation
            {
            }

            public class ExtraService : ChannelsECProductAddRequest.Types.ExtraService
            {
            }

            public class Aftersale : ChannelsECProductAddRequest.Types.Aftersale
            {
            }

            public class Qualification : ChannelsECProductAddRequest.Types.Qualification
            {
            }

            public class SizeChart : ChannelsECProductAddRequest.Types.SizeChart
            {
                public static new class Types
                {
                    public class Specification : ChannelsECProductAddRequest.Types.SizeChart.Types.Specification
                    {
                        public static new class Types
                        {
                            public class SpecificationValue : ChannelsECProductAddRequest.Types.SizeChart.Types.Specification.Types.SpecificationValue
                            {
                            }
                        }
                    }
                }
            }

            public class TimingOnSale : ChannelsECProductAddRequest.Types.TimingOnSale
            {
            }
        }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置商品标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品短标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("short_title")]
        [System.Text.Json.Serialization.JsonPropertyName("short_title")]
        public string? ShortTitle { get; set; }

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
        [Obsolete("相关接口或字段于 2024-10-28 下线。")]
        [Newtonsoft.Json.JsonProperty("cats")]
        [System.Text.Json.Serialization.JsonPropertyName("cats")]
        public IList<Types.Category>? CategoryList { get; set; }

        /// <summary>
        /// 获取或设置新版商品类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cats_v2")]
        [System.Text.Json.Serialization.JsonPropertyName("cats_v2")]
        public IList<Types.Category>? CategoryV2List { get; set; }

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
        public string? SPUCode { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long? BrandId { get; set; }

        /// <summary>
        /// 获取或设置商品资质图片媒体文件标识 ID 列表。
        /// </summary>
        [Obsolete("相关接口或字段于 2024-04-29 下线。")]
        [Newtonsoft.Json.JsonProperty("qualifications")]
        [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
        public IList<string>? QualificationPictureMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置商品资质列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_qua_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("product_qua_infos")]
        public IList<Types.Qualification>? ProductQualificationList { get; set; }

        /// <summary>
        /// 获取或设置发货方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliver_method")]
        [System.Text.Json.Serialization.JsonPropertyName("deliver_method")]
        public int? DeliverMethod { get; set; }

        /// <summary>
        /// 获取或设置发货账号类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliver_acct_type")]
        [System.Text.Json.Serialization.JsonPropertyName("deliver_acct_type")]
        public IList<int>? DeliverAccountTypeList { get; set; }

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

        /// <summary>
        /// 获取或设置尺码表信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size_chart")]
        [System.Text.Json.Serialization.JsonPropertyName("size_chart")]
        public Types.SizeChart? SizeChart { get; set; }

        /// <summary>
        /// 获取或设置待开售信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timing_onsale_info")]
        [System.Text.Json.Serialization.JsonPropertyName("timing_onsale_info")]
        public Types.TimingOnSale? TimingOnSale { get; set; }

        /// <summary>
        /// 获取或设置发布模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("release_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("release_mode")]
        public int? ReleaseMode { get; set; }
    }
}
