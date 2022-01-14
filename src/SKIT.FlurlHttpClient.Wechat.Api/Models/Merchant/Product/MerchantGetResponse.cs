namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/get 接口的响应。</para>
    /// </summary>
    public class MerchantGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class Base
                    {
                        public static class Types
                        {
                            public class Property : MerchantCreateRequest.Types.Base.Types.Property
                            {
                            }

                            public class SKUProperty
                            {
                                /// <summary>
                                /// 获取或设置属性 Id。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string Id { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值 Id 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("vid")]
                                [System.Text.Json.Serialization.JsonPropertyName("vid")]
                                public string[] ValueIdList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品分类 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                        public string[] CategoryIdList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品主图 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("main_img")]
                        [System.Text.Json.Serialization.JsonPropertyName("main_img")]
                        public string MainImageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("img")]
                        [System.Text.Json.Serialization.JsonPropertyName("img")]
                        public string[] ImageUrlList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品详情 HTML。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail_html")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail_html")]
                        public string DetailHtml { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("property")]
                        [System.Text.Json.Serialization.JsonPropertyName("property")]
                        public Types.Property[] PropertyList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品 SKU 定义列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_info")]
                        public Types.SKUProperty[] SKUPropertyList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户商品限购数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buy_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("buy_limit")]
                        public int? BuyLimit { get; set; }
                    }

                    public class SKU : MerchantCreateRequest.Types.SKU
                    {
                    }

                    public class AttributeExtra : MerchantCreateRequest.Types.AttributeExtra
                    {
                    }

                    public class Delivery
                    {
                        public static class Types
                        {
                            public class Express : MerchantCreateRequest.Types.Delivery.Types.Express
                            {
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
                        public Types.Express[]? ExpressList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public string ProductId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_base")]
                [System.Text.Json.Serialization.JsonPropertyName("product_base")]
                public Types.Base Base { get; set; } = default!;

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_list")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_list")]
                public Types.SKU[] SKUList { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品其他属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attrext")]
                [System.Text.Json.Serialization.JsonPropertyName("attrext")]
                public Types.AttributeExtra AttributeExtra { get; set; } = default!;

                /// <summary>
                /// 获取或设置运费信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_info")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_info")]
                public Types.Delivery? Delivery { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_info")]
        [System.Text.Json.Serialization.JsonPropertyName("product_info")]
        public Types.Product Product { get; set; } = default!;
    }
}
