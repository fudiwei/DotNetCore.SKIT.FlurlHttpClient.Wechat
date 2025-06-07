using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/window/getdetail 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierWindowGetDetailResponse : WechatApiResponse
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
                        /// 获取或设置商品类目列表。
                        /// </summary>
                        [Obsolete("相关接口或字段于 2024-10-28 下线。")]
                        [Newtonsoft.Json.JsonProperty("cats")]
                        [System.Text.Json.Serialization.JsonPropertyName("cats")]
                        public Types.Category[]? CategoryList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置新版商品类目列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cats_v2")]
                        [System.Text.Json.Serialization.JsonPropertyName("cats_v2")]
                        public Types.Category[]? CategoryV2List { get; set; }

                        /// <summary>
                        /// 获取或设置商品小程序跳转小店场景添加商品时传递的推广信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_promotion_link")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_promotion_link")]
                        public string? ProductPromotionLink { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_info")]
                [System.Text.Json.Serialization.JsonPropertyName("product_info")]
                public Types.ProductInfo ProductInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("product_detail")]
        public Types.Product Product { get; set; } = default!;
    }
}
