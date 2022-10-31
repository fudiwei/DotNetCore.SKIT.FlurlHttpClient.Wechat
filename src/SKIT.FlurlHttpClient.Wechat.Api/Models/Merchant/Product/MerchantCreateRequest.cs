using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/create 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2020-10-01 下线。")]
    public class MerchantCreateRequest : WechatApiRequest, IInferable<MerchantCreateRequest, MerchantCreateResponse>
    {
        public static class Types
        {
            public class Base
            {
                public static class Types
                {
                    public class Detail
                    {
                        /// <summary>
                        /// 获取或设置文字描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public string? Text { get; set; }

                        /// <summary>
                        /// 获取或设置图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("img")]
                        [System.Text.Json.Serialization.JsonPropertyName("img")]
                        public string? ImageUrl { get; set; }
                    }

                    public class Property
                    {
                        /// <summary>
                        /// 获取或设置属性 Id。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置属性值 Id。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("vid")]
                        [System.Text.Json.Serialization.JsonPropertyName("vid")]
                        public string ValueId { get; set; } = string.Empty;
                    }

                    public class SKUValue
                    {
                        /// <summary>
                        /// 获取或设置 SKU Id。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置 SKU VID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("vid")]
                        [System.Text.Json.Serialization.JsonPropertyName("vid")]
                        public IList<string> ValueIdList { get; set; } = new List<string>();
                    }
                }

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品分类 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                public IList<string> CategoryIdList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置商品主图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("main_img")]
                [System.Text.Json.Serialization.JsonPropertyName("main_img")]
                public string MainImageUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品图片 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img")]
                [System.Text.Json.Serialization.JsonPropertyName("img")]
                public IList<string> ImageUrlList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置商品详情列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail")]
                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                public IList<Types.Detail> DetailList { get; set; } = new List<Types.Detail>();

                /// <summary>
                /// 获取或设置商品属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property")]
                [System.Text.Json.Serialization.JsonPropertyName("property")]
                public IList<Types.Property> PropertyList { get; set; } = new List<Types.Property>();

                /// <summary>
                /// 获取或设置商品 SKU 定义列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_info")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_info")]
                public IList<Types.SKUValue> SKUValueList { get; set; } = new List<Types.SKUValue>();

                /// <summary>
                /// 获取或设置用户商品限购数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buy_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("buy_limit")]
                public int? BuyLimit { get; set; }
            }

            public class SKU
            {
                /// <summary>
                /// 获取或设置 SKU Id。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                public string Id { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置原价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ori_price")]
                [System.Text.Json.Serialization.JsonPropertyName("ori_price")]
                public int OriginalPrice { get; set; }

                /// <summary>
                /// 获取或设置微信价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public int Price { get; set; }

                /// <summary>
                /// 获取或设置图标 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("icon_url")]
                [System.Text.Json.Serialization.JsonPropertyName("icon_url")]
                public string IconUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quantity")]
                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                public int Quantity { get; set; }

                /// <summary>
                /// 获取或设置商家商品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_code")]
                [System.Text.Json.Serialization.JsonPropertyName("product_code")]
                public string ProductCode { get; set; } = string.Empty;
            }

            public class AttributeExtra
            {
                public static class Types
                {
                    public class Location
                    {
                        /// <summary>
                        /// 获取或设置国家。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("country")]
                        [System.Text.Json.Serialization.JsonPropertyName("country")]
                        public string Country { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置省份。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province")]
                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                        public string Province { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string City { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string Address { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置商品所在地地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public Types.Location? Location { get; set; }

                /// <summary>
                /// 获取或设置是否包邮。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("isPostFree")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("isPostFree")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsPostFree { get; set; }

                /// <summary>
                /// 获取或设置是否提供发票。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("isHasReceipt")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("isHasReceipt")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsHasFree { get; set; }

                /// <summary>
                /// 获取或设置是否保修。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("isUnderGuaranty")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("isUnderGuaranty")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsUnderGuaranty { get; set; }

                /// <summary>
                /// 获取或设置是否支持退换货。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("isSupportReplace")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("isSupportReplace")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsSupportReplace { get; set; }
            }

            public class Delivery
            {
                public static class Types
                {
                    public class Express
                    {
                        /// <summary>
                        /// 获取或设置快递公司 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public int Id { get; set; }

                        /// <summary>
                        /// 获取或设置运费（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public int Price { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置运费类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_type")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_type")]
                public int DeliveryType { get; set; }

                /// <summary>
                /// 获取或设置邮费模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public int? TemplateId { get; set; }

                /// <summary>
                /// 获取或设置快递列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("express")]
                [System.Text.Json.Serialization.JsonPropertyName("express")]
                public IList<Types.Express>? ExpressList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品基本信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_base")]
        [System.Text.Json.Serialization.JsonPropertyName("product_base")]
        public Types.Base Base { get; set; } = new Types.Base();

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_list")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_list")]
        public IList<Types.SKU>? SKUList { get; set; }

        /// <summary>
        /// 获取或设置商品其他属性。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attrext")]
        [System.Text.Json.Serialization.JsonPropertyName("attrext")]
        public Types.AttributeExtra? AttributeExtra { get; set; }

        /// <summary>
        /// 获取或设置运费信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_info")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_info")]
        public Types.Delivery? Delivery { get; set; }
    }
}
