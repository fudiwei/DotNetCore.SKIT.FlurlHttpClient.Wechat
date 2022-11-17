namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/gettemplatedraftlist 接口的响应。</para>
    /// </summary>
    public class WxaGetTemplateDraftListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Draft
            {
                /// <summary>
                /// 获取或设置草稿 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("draft_id")]
                [System.Text.Json.Serialization.JsonPropertyName("draft_id")]
                public long DraftId { get; set; }

                /// <summary>
                /// 获取或设置用户自定义版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_version")]
                [System.Text.Json.Serialization.JsonPropertyName("user_version")]
                public string UserVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户自定义版本描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
                public string UserDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置上传时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置草稿列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("draft_list")]
        [System.Text.Json.Serialization.JsonPropertyName("draft_list")]
        public Types.Draft[] DraftList { get; set; } = default!;
    }
}
