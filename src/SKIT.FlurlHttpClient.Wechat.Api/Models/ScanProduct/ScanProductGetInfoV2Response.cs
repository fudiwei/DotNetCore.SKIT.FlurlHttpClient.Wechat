namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /scan/product/v2/getinfo 接口的响应。</para>
    /// </summary>
    public class ScanProductGetInfoV2Response : WechatApiResponse
    {
        public static class Types
        {
            public class Product : ScanProductAddV2Request.Types.__zz__Product
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
                        public List<ImageItem>? Items { get; set; }
                    }

                    public class ImageItem : ScanProductAddV2Request.Types.Product.Types.ImageItem
                    {
                    }

                    public class CategoryList
                    {
                        /// <summary>
                        /// 获取或设置分类列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_item")]
                        public List<CategoryItem>? Items { get; set; }
                    }

                    public class CategoryItem : ScanProductAddV2Request.Types.Product.Types.CategoryItem
                    {
                    }

                    public class TagList
                    {
                        /// <summary>
                        /// 获取或设置标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_item")]
                        public List<TagItem>? Items { get; set; }
                    }

                    public class TagItem : ScanProductAddV2Request.Types.Product.Types.TagItem
                    {
                    }

                    public class AttributeList
                    {
                        /// <summary>
                        /// 获取或设置属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attribute_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("attribute_item")]
                        public List<AttributeItem>? Items { get; set; }
                    }

                    public class AttributeItem : ScanProductAddV2Request.Types.Product.Types.AttributeItem
                    {
                    }

                    public class CustomList
                    {
                        /// <summary>
                        /// 获取或设置自定义属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_list")]
                        public List<CustomItem>? Items { get; set; }
                    }

                    public class CustomItem : ScanProductAddV2Request.Types.Product.Types.CustomItem
                    {
                    }

                    public class Link : ScanProductAddV2Request.Types.Product.Types.Link
                    {
                    }

                    public class Shop : ScanProductAddV2Request.Types.Product.Types.Shop
                    {
                    }

                    public class Price : ScanProductAddV2Request.Types.Product.Types.Price
                    {
                    }

                    public class Sale : ScanProductAddV2Request.Types.Product.Types.Sale
                    {
                    }

                    public class SKUList
                    {
                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_item")]
                        public List<SKUItem>? Items { get; set; }
                    }

                    public class SKUItem : ScanProductAddV2Request.Types.Product.Types.__zz__SKUItem
                    {
                        /// <summary>
                        /// 获取或设置商品图片信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_info")]
                        public ImageList? Image { get; set; }

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
                /// 获取或设置店铺信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_info")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_info")]
                public Types.Shop? Shop { get; set; }

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
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product? Product { get; set; }
    }
}
