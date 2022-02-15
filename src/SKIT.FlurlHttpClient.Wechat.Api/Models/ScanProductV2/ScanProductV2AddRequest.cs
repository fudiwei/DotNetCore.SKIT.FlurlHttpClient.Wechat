using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /scan/product/v2/add 接口的请求。</para>
    /// </summary>
    public class ScanProductV2AddRequest : WechatApiRequest, IMapResponse<ScanProductV2AddRequest, ScanProductV2AddResponse>
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class ImageList
                    {
                        /// <summary>
                        /// 获取或设置图片列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("main_image_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("main_image_list")]
                        public IList<ImageItem> Items { get; set; } = new List<ImageItem>();
                    }

                    public class ImageItem
                    {
                        /// <summary>
                        /// 获取或设置图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = string.Empty;
                    }

                    public class CategoryList
                    {
                        /// <summary>
                        /// 获取或设置分类列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_item")]
                        public IList<CategoryItem> Items { get; set; } = new List<CategoryItem>();
                    }

                    public class CategoryItem
                    {
                        /// <summary>
                        /// 获取或设置分类名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                        public string Name { get; set; } = string.Empty;
                    }

                    public class TagList
                    {
                        /// <summary>
                        /// 获取或设置标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_item")]
                        public IList<TagItem> Items { get; set; } = new List<TagItem>();
                    }

                    public class TagItem
                    {
                        /// <summary>
                        /// 获取或设置标签名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_name")]
                        public string Name { get; set; } = string.Empty;
                    }

                    public class AttributeList
                    {
                        /// <summary>
                        /// 获取或设置属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attribute_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("attribute_item")]
                        public IList<AttributeItem> Items { get; set; } = new List<AttributeItem>();
                    }

                    public class AttributeItem
                    {
                        /// <summary>
                        /// 获取或设置属性的 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attribute_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("attribute_key")]
                        public string Key { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置属性的值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attribute_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("attribute_value")]
                        public string Value { get; set; } = string.Empty;
                    }

                    public class CustomList
                    {
                        /// <summary>
                        /// 获取或设置自定义属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_list")]
                        public IList<CustomItem> Items { get; set; } = new List<CustomItem>();
                    }

                    public class CustomItem
                    {
                        /// <summary>
                        /// 获取或设置自定义属性的 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string Key { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置自定义属性的值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }

                    public class Link
                    {
                        /// <summary>
                        /// 获取或设置关联类型。
                        /// <para>默认值：wxa</para>
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("link_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("link_type")]
                        public string LinkType { get; set; } = "wxa";

                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wxa_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("wxa_appid")]
                        public string? MiniProgramAppId { get; set; }

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? PagePath { get; set; }
                    }

                    public class Shop
                    {
                        /// <summary>
                        /// 获取或设置商品来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("source")]
                        [System.Text.Json.Serialization.JsonPropertyName("source")]
                        public int? Source { get; set; }
                    }

                    public class Price
                    {
                        /// <summary>
                        /// 获取或设置现价最低价（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("min_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("min_price")]
                        public double MinPrice { get; set; }

                        /// <summary>
                        /// 获取或设置现价最高价（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("max_price")]
                        public double MaxPrice { get; set; }

                        /// <summary>
                        /// 获取或设置原价最低价（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("min_ori_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("min_ori_price")]
                        public double? MinOriginalPrice { get; set; }

                        /// <summary>
                        /// 获取或设置原价最高价（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max_ori_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("max_ori_price")]
                        public double? MaxOriginalPrice { get; set; }
                    }

                    public class Sale
                    {
                        /// <summary>
                        /// 获取或设置销售状态。
                        /// <para>默认值：off</para>
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sale_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("sale_status")]
                        public string SaleStatus { get; set; } = "off";

                        /// <summary>
                        /// 获取或设置商品库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock")]
                        public int? Stock { get; set; }
                    }

                    public class SKUList
                    {
                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_item")]
                        public IList<SKUItem> Items { get; set; } = new List<SKUItem>();
                    }

                    public class SKUItem
                    {
                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public string? SKUId { get; set; }

                        /// <summary>
                        /// 获取或设置商品条码类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("barcode_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("barcode_type")]
                        public string? BarCodeType { get; set; }

                        /// <summary>
                        /// 获取或设置商品条码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("barcode")]
                        [System.Text.Json.Serialization.JsonPropertyName("barcode")]
                        public string? BarCode { get; set; }

                        /// <summary>
                        /// 获取或设置商品来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("source")]
                        [System.Text.Json.Serialization.JsonPropertyName("source")]
                        public int? Source { get; set; }

                        /// <summary>
                        /// 获取或设置商品图片信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_info")]
                        public ImageList? Image { get; set; }

                        /// <summary>
                        /// 获取或设置关联的小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("link_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("link_url")]
                        public string? LinkMiniProgramPagePath { get; set; }

                        /// <summary>
                        /// 获取或设置商品价格信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("price_info")]
                        public Price? Price { get; set; }

                        /// <summary>
                        /// 获取或设置商品销售信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sale_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("sale_info")]
                        public Sale? Sale { get; set; }

                        /// <summary>
                        /// 获取或设置店铺信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_info")]
                        public Shop? Shop { get; set; }

                        /// <summary>
                        /// 获取或设置属性信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attribute_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("attribute_info")]
                        public AttributeList? Attribute { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pid")]
                [System.Text.Json.Serialization.JsonPropertyName("pid")]
                public string ProductId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品图片信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_info")]
                [System.Text.Json.Serialization.JsonPropertyName("image_info")]
                public Types.ImageList? Image { get; set; }

                /// <summary>
                /// 获取或设置商户商品分类信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_info")]
                [System.Text.Json.Serialization.JsonPropertyName("category_info")]
                public Types.CategoryList? Category { get; set; }

                /// <summary>
                /// 获取或设置微信商品分类信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("official_category_info")]
                [System.Text.Json.Serialization.JsonPropertyName("official_category_info")]
                public Types.CategoryList? OfficialCategory { get; set; }

                /// <summary>
                /// 获取或设置商品标签信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag_info")]
                [System.Text.Json.Serialization.JsonPropertyName("tag_info")]
                public Types.TagList? Tag { get; set; }

                /// <summary>
                /// 获取或设置关联信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link_info")]
                [System.Text.Json.Serialization.JsonPropertyName("link_info")]
                public Types.Link? Link { get; set; }

                /// <summary>
                /// 获取或设置商品标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置商品附标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_title")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_title")]
                public string? SubTitle { get; set; }

                /// <summary>
                /// 获取或设置商品品牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand")]
                [System.Text.Json.Serialization.JsonPropertyName("brand")]
                public string? Brand { get; set; }

                /// <summary>
                /// 获取或设置店铺信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_info")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_info")]
                public Types.Shop? Shop { get; set; }

                /// <summary>
                /// 获取或设置商品描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置价格信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price_info")]
                [System.Text.Json.Serialization.JsonPropertyName("price_info")]
                public Types.Price? Price { get; set; }

                /// <summary>
                /// 获取或设置售卖信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sale_info")]
                [System.Text.Json.Serialization.JsonPropertyName("sale_info")]
                public Types.Sale? Sale { get; set; }

                /// <summary>
                /// 获取或设置 SKU 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_info")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_info")]
                public Types.SKUList? SKU { get; set; }

                /// <summary>
                /// 获取或设置自定义属性信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_info")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_info")]
                public Types.CustomList? Custom { get; set; }

                /// <summary>
                /// 获取或设置是否增量更新。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("partial_update")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("partial_update")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsPartialUpdate { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();
    }
}
