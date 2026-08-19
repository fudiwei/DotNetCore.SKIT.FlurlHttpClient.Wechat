using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/addproductthirdpartysource 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductAddProductThirdPartySourceRequest : WechatApiRequest, IInferable<ChannelsECProductAddProductThirdPartySourceRequest, ChannelsECProductAddProductThirdPartySourceResponse>
    {
        public static class Types
        {
            public class Supplier
            {
                /// <summary>
                /// 获取或设置货主主体名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_name")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_name")]
                public string SupplierName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置货源平台类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source_platform_type")]
                [System.Text.Json.Serialization.JsonPropertyName("source_platform_type")]
                public int? SourcePlatformType { get; set; }

                /// <summary>
                /// 获取或设置货源平台名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source_platform_name")]
                [System.Text.Json.Serialization.JsonPropertyName("source_platform_name")]
                public string? SourcePlatformName { get; set; } = string.Empty;
            }

            public class SupplierShopPerformance
            {
                /// <summary>
                /// 获取或设置 24 小时揽收率（单位：百分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("accept_rate_24h")]
                [System.Text.Json.Serialization.JsonPropertyName("accept_rate_24h")]
                public int? AcceptRateIn24Hours { get; set; }

                /// <summary>
                /// 获取或设置 48 小时揽收率（单位：百分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("accept_rate_48h")]
                [System.Text.Json.Serialization.JsonPropertyName("accept_rate_48h")]
                public int? AcceptRateIn48Hours { get; set; }

                /// <summary>
                /// 获取或设置近 7 天代发数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ship_count_7d")]
                [System.Text.Json.Serialization.JsonPropertyName("ship_count_7d")]
                public int? ShipCountIn7Days { get; set; }

                /// <summary>
                /// 获取或设置近 30 天代发数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ship_count_30d")]
                [System.Text.Json.Serialization.JsonPropertyName("ship_count_30d")]
                public int? ShipCountIn30Days { get; set; }

                /// <summary>
                /// 获取或设置铺货分销商数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("distribute_product_count")]
                [System.Text.Json.Serialization.JsonPropertyName("distribute_product_count")]
                public int? DistributeProductCount { get; set; }

                /// <summary>
                /// 获取或设置准时发货率（单位：百分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("on_time_ship_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("on_time_ship_rate")]
                public int? OnTimeShipRate { get; set; }

                /// <summary>
                /// 获取或设置商家身份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_identity")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_identity")]
                public string? MerchantIdentity { get; set; }
            }

            public class ProductSourceInfo
            {
                public static class Types
                {
                    public class Attribute
                    {
                        /// <summary>
                        /// 获取或设置属性类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attr_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("attr_type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置属性名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attr_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("attr_name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置属性值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attr_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("attr_value")]
                        public string? Value { get; set; }
                    }

                    public class SKU
                    {
                        /// <summary>
                        /// 获取或设置商家自定义 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public string OutSKUId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置规格名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spec_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("spec_name")]
                        public string SpecificationName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置规格值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spec_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("spec_value")]
                        public string SpecificationValue { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置图片 Url。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_img")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_img")]
                        public string ImageUrl { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public int Price { get; set; }

                        /// <summary>
                        /// 获取或设置库存类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock_type")]
                        public int StockType { get; set; }

                        /// <summary>
                        /// 获取或设置库存数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock")]
                        public int Stock { get; set; }
                    }

                    public class Logistics
                    {
                        /// <summary>
                        /// 获取或设置运费信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("freight_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("freight_info")]
                        public string? FreightInfo { get; set; }

                        /// <summary>
                        /// 获取或设置物流模版。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logistics_template")]
                        [System.Text.Json.Serialization.JsonPropertyName("logistics_template")]
                        public string? LogisticsTemplate { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商家自定义商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public string OutProductId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置可访问链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("visit_url")]
                [System.Text.Json.Serialization.JsonPropertyName("visit_url")]
                public string VisitUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品主图 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_img_urls")]
                [System.Text.Json.Serialization.JsonPropertyName("head_img_urls")]
                public IList<string> HeadImageUrlList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置商品详情图 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_img_urls")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_img_urls")]
                public IList<string> DetailImageUrlList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置商品详情描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_description")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_description")]
                public string? DetailDescription { get; set; }

                /// <summary>
                /// 获取或设置商品资质图片 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_list")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_list")]
                public IList<string>? QualificationPictureUrlList { get; set; }

                /// <summary>
                /// 获取或设置商品品牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand")]
                [System.Text.Json.Serialization.JsonPropertyName("brand")]
                public string? Brand { get; set; }

                /// <summary>
                /// 获取或设置商品属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attr_list")]
                [System.Text.Json.Serialization.JsonPropertyName("attr_list")]
                public IList<Types.Attribute>? AttributeList { get; set; }

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_list")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_list")]
                public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();

                /// <summary>
                /// 获取或设置物流信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logistics_info")]
                [System.Text.Json.Serialization.JsonPropertyName("logistics_info")]
                public Types.Logistics? Logistics { get; set; }

                /// <summary>
                /// 获取或设置服务保障文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_guarantee")]
                [System.Text.Json.Serialization.JsonPropertyName("service_guarantee")]
                public string? ServiceGuaranteeText { get; set; }

                /// <summary>
                /// 获取或设置发货时间文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_time")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_time")]
                public string? DeliveryTimeText { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_value")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_value")]
        public int Scene { get; set; }

        /// <summary>
        /// 获取或设置商品发布方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_method")]
        [System.Text.Json.Serialization.JsonPropertyName("publish_method")]
        public int? PublishMthod { get; set; }

        /// <summary>
        /// 获取或设置货主信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier")]
        public Types.Supplier? Supplier { get; set; }

        /// <summary>
        /// 获取或设置货主店铺经营表现信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_shop_performance")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_shop_performance")]
        public Types.SupplierShopPerformance? SupplierShopPerformance { get; set; }

        /// <summary>
        /// 获取或设置商品在货源平台的信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_source_info")]
        [System.Text.Json.Serialization.JsonPropertyName("product_source_info")]
        public Types.ProductSourceInfo ProductSourceInfo { get; set; } = new Types.ProductSourceInfo();
    }
}
