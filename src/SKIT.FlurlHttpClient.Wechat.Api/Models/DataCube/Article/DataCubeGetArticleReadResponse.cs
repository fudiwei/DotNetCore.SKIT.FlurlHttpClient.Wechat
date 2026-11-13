namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getarticleread 接口的响应。</para>
    /// </summary>
    public class DataCubeGetArticleReadResponse : WechatApiResponse
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
                            public class ReadSourceData
                            {
                                /// <summary>
                                /// 获取或设置场景描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("scene_desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("scene_desc")]
                                public string? SceneDescription { get; set; }

                                /// <summary>
                                /// 获取或设置阅读人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_count")]
                                public int UserCount { get; set; }
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
