using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/homepage/banner/apply/submit 接口的请求。</para>
    /// </summary>
    public class ChannelsECBasicsHomepageBannerApplySubmitRequest : WechatApiRequest, IInferable<ChannelsECBasicsHomepageBannerApplySubmitRequest, ChannelsECBasicsHomepageBannerApplySubmitResponse>
    {
        public static class Types
        {
            public class BannerList
            {
                /// <summary>
                /// 获取或设置展示样式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scale")]
                [System.Text.Json.Serialization.JsonPropertyName("scale")]
                public int Scale { get; set; }

                /// <summary>
                /// 获取或设置展示位列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("banner")]
                [System.Text.Json.Serialization.JsonPropertyName("banner")]
                public IList<BannerItem> Items { get; set; } = new List<BannerItem>();
            }

            public class BannerItem
            {
                public static class Types
                {
                    public class Banner
                    {
                        /// <summary>
                        /// 获取或设置图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("img_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("img_url")]
                        public string ImageUrl { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string? Title { get; set; }

                        /// <summary>
                        /// 获取或设置描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string? Description { get; set; }
                    }

                    public class Product
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public long ProductId { get; set; }
                    }

                    public class Finder
                    {
                        /// <summary>
                        /// 获取或设置视频号 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finder_user_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("finder_user_name")]
                        public string? FinderUsername { get; set; }

                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("feed_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("feed_id")]
                        public string? FeedId { get; set; }
                    }

                    public class OfficialAccount
                    {
                        /// <summary>
                        /// 获取或设置公众号文章链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置展示位类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置展示位信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("banner")]
                [System.Text.Json.Serialization.JsonPropertyName("banner")]
                public Types.Banner Banner { get; set; } = new Types.Banner();

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product")]
                [System.Text.Json.Serialization.JsonPropertyName("product")]
                public Types.Product? Product { get; set; }

                /// <summary>
                /// 获取或设置视频号信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finder")]
                [System.Text.Json.Serialization.JsonPropertyName("finder")]
                public Types.Finder? Finder { get; set; }

                /// <summary>
                /// 获取或设置公众号信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("official_account")]
                [System.Text.Json.Serialization.JsonPropertyName("official_account")]
                public Types.OfficialAccount? OfficialAccount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置展示位列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("banner")]
        [System.Text.Json.Serialization.JsonPropertyName("banner")]
        public Types.BannerList BannerList { get; set; } = new Types.BannerList();
    }
}
