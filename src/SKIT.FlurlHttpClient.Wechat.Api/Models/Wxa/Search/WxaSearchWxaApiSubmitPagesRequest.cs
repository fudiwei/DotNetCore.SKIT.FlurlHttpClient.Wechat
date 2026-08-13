using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/search/wxaapi_submitpages 接口的请求。</para>
    /// </summary>
    public class WxaSearchWxaApiSubmitPagesRequest : WechatApiRequest, IInferable<WxaSearchWxaApiSubmitPagesRequest, WxaSearchWxaApiSubmitPagesResponse>
    {
        public static class Types
        {
            public class Page
            {
                public static class Types
                {
                    public class Data
                    {
                        public static class Types
                        {
                            public class Author
                            {
                                /// <summary>
                                /// 获取或设置名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("author_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("author_name")]
                                public string Name { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置职务。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("author_title")]
                                [System.Text.Json.Serialization.JsonPropertyName("author_title")]
                                public string? Title { get; set; }

                                /// <summary>
                                /// 获取或设置头像 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("author_portrait")]
                                [System.Text.Json.Serialization.JsonPropertyName("author_portrait")]
                                public string? PortraitUrl { get; set; }
                            }

                            public class Video
                            {
                                /// <summary>
                                /// 获取或设置标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("video_title")]
                                [System.Text.Json.Serialization.JsonPropertyName("video_title")]
                                public string? Title { get; set; }

                                /// <summary>
                                /// 获取或设置时长（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("video_length")]
                                [System.Text.Json.Serialization.JsonPropertyName("video_length")]
                                public int Length { get; set; }

                                /// <summary>
                                /// 获取或设置封面图 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("video_img")]
                                [System.Text.Json.Serialization.JsonPropertyName("video_img")]
                                public string ImageUrl { get; set; } = string.Empty;
                            }
                        }

                        /// <summary>
                        /// 获取或设置数据结构类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("@type")]
                        [System.Text.Json.Serialization.JsonPropertyName("@type")]
                        public string Type { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置更新类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update")]
                        [System.Text.Json.Serialization.JsonPropertyName("update")]
                        public int UpdateType { get; set; }

                        /// <summary>
                        /// 获取或设置数据方自定义 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("content_id")]
                        public string ContentId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置页面类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("page_type")]
                        public int PageType { get; set; }

                        /// <summary>
                        /// 获取或设置 H5 链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("h5_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("h5_url")]
                        public string? H5Url { get; set; }

                        /// <summary>
                        /// 获取或设置标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string? Title { get; set; }

                        /// <summary>
                        /// 获取或设置摘要列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("abstract")]
                        [System.Text.Json.Serialization.JsonPropertyName("abstract")]
                        public IList<string>? AbstractList { get; set; }

                        /// <summary>
                        /// 获取或设置 HTTP Referrer。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("referer")]
                        [System.Text.Json.Serialization.JsonPropertyName("referer")]
                        public string? HttpReferrer { get; set; }

                        /// <summary>
                        /// 获取或设置封面图 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cover_img_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("cover_img_url")]
                        public string? CoverImageUrl { get; set; }

                        /// <summary>
                        /// 获取或设置正文。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mainbody")]
                        [System.Text.Json.Serialization.JsonPropertyName("mainbody")]
                        public string? MainBody { get; set; }

                        /// <summary>
                        /// 获取或设置作者信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("author")]
                        [System.Text.Json.Serialization.JsonPropertyName("author")]
                        public Types.Author? Author { get; set; }

                        /// <summary>
                        /// 获取或设置视频列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video")]
                        [System.Text.Json.Serialization.JsonPropertyName("video")]
                        public IList<Types.Video>? VideoList { get; set; }

                        /// <summary>
                        /// 获取或设置发布时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time_publish")]
                        [System.Text.Json.Serialization.JsonPropertyName("time_publish")]
                        public long? PublishTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time_modify")]
                        [System.Text.Json.Serialization.JsonPropertyName("time_modify")]
                        public long? ModifyTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置补充字段。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("extra_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("extra_info")]
                        public IDictionary<string, string>? ExtraInfo { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string Path { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置页面参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query")]
                [System.Text.Json.Serialization.JsonPropertyName("query")]
                public string Query { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置页面数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("data_list")]
                public IList<Types.Data>? DataList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置小程序页面信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pages")]
        [System.Text.Json.Serialization.JsonPropertyName("pages")]
        public IList<Types.Page> PageList { get; set; } = new List<Types.Page>();
    }
}
