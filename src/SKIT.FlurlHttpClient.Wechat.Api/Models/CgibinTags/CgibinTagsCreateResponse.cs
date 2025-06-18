namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tags/create 接口的响应。</para>
    /// </summary>
    public class CgibinTagsCreateResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Tag
            {
                /// <summary>
                /// 获取或设置标签 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int Id { get; set; }

                /// <summary>
                /// 获取或设置标签名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置批量获取的用户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public Types.Tag Tag { get; set; } = default!;
    }
}
