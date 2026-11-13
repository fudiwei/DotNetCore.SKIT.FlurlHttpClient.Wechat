namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getarticleshare 接口的响应。</para>
    /// </summary>
    public class DataCubeGetArticleShareResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Detail
                    {
                        /// <summary>
                        /// 获取或设置分享人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_user")]
                        public int ShareUserCount { get; set; }
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
