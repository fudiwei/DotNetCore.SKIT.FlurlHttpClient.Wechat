namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/feedback/list 接口的响应。</para>
    /// </summary>
    public class WxaApiFeedbackListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Feedback
            {
                /// <summary>
                /// 获取或设置反馈 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("record_id")]
                [System.Text.Json.Serialization.JsonPropertyName("record_id")]
                public long RecordId { get; set; }

                /// <summary>
                /// 获取或设置反馈用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置反馈用户昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置反馈用户头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_url")]
                [System.Text.Json.Serialization.JsonPropertyName("head_url")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置反馈用户手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
                public string? MobileNumber { get; set; }

                /// <summary>
                /// 获取或设置反馈类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置反馈内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置反馈截图媒体文件标识列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mediaIds")]
                [System.Text.Json.Serialization.JsonPropertyName("mediaIds")]
                public string[]? MediaIdList { get; set; }

                /// <summary>
                /// 获取或设置反馈用户 JSON 格式的系统信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("systemInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("systemInfo")]
                public string? JsonSystemInformation { get; set; }

                /// <summary>
                /// 获取或设置反馈时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置反馈列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Feedback[] FeedbackList { get; set; } = default!;

        /// <summary>
        /// 获取或设置反馈总条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
