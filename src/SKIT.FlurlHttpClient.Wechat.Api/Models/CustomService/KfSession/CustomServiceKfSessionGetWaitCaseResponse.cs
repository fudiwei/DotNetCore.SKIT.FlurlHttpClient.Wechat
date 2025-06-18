namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /customservice/kfsession/getwaitcase 接口的响应。</para>
    /// </summary>
    public class CustomServiceKfSessionGetWaitCaseResponse : WechatApiResponse
    {
        public static class Types
        {
            public class WaitCase
            {
                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置最后一条消息的时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("latest_time")]
                [System.Text.Json.Serialization.JsonPropertyName("latest_time")]
                public long LatestTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置未接入会话数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// 获取或设置未接入会话列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waitcaselist")]
        [System.Text.Json.Serialization.JsonPropertyName("waitcaselist")]
        public Types.WaitCase[] WaitCaseList { get; set; } = default!;
    }
}
