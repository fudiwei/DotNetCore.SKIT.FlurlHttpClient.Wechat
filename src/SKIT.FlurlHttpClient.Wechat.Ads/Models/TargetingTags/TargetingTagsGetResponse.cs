namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /targeting_tags/get 接口的响应。</para>
    /// </summary>
    public class TargetingTagsGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Tag
                    {
                        /// <summary>
                        /// 获取或设置 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public int Id { get; set; }

                        /// <summary>
                        /// 获取或设置名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置上级 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parent_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
                        public int ParentId { get; set; }

                        /// <summary>
                        /// 获取或设置上级名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parent_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("parent_name")]
                        public string ParentName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置城市级别。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city_level")]
                        [System.Text.Json.Serialization.JsonPropertyName("city_level")]
                        public string? CityLevel { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置标签列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Tag[] TagList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
