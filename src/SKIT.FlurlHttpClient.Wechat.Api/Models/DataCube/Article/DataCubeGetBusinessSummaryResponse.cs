namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getbizsummary 接口的响应。</para>
    /// </summary>
    public class DataCubeGetBusinessSummaryResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Detail
                    {
                        public static class Types
                        {
                            public class ReadSourceData : DataCubeGetArticleReadResponse.Types.Data.Types.Detail.Types.ReadSourceData
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置阅读人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("read_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("read_user")]
                        public int ReadUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置阅读场景数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("read_user_source")]
                        [System.Text.Json.Serialization.JsonPropertyName("read_user_source")]
                        public List<Types.ReadSourceData>? ReadUserSourceList { get; set; }

                        /// <summary>
                        /// 获取或设置分享人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_user")]
                        public int ShareUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置在看人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("zaikan_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("zaikan_user")]
                        public int ZaikanUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置点赞人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("like_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("like_user")]
                        public int LikeUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置留言条数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_count")]
                        public int CommentCount { get; set; }

                        /// <summary>
                        /// 获取或设置收藏人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("collection_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("collection_user")]
                        public int CollectionUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置跳转原文人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("redirect_ori_page_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("redirect_ori_page_user")]
                        public int RedirectOriginPageUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置发布篇数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("send_page_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("send_page_count")]
                        public int SendPageCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置数据的日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ref_date")]
                [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
                public string? RefDateString { get; set; }

                /// <summary>
                /// 获取或设置图文消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgid")]
                [System.Text.Json.Serialization.JsonPropertyName("msgid")]
                public string? MessageId { get; set; }

                /// <summary>
                /// 获取或设置数据详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail")]
                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                public Types.Detail? Detail { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public List<Types.Data>? DataList { get; set; }

        /// <summary>
        /// 获取或设置数据是否有延迟。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_delay")]
        [System.Text.Json.Serialization.JsonPropertyName("is_delay")]
        public bool IsDelay { get; set; }
    }
}
