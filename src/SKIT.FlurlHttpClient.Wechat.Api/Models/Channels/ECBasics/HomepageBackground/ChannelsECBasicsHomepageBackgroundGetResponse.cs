namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/homepage/background/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECBasicsHomepageBackgroundGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Apply
            {
                /// <summary>
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("img_url")]
                public string ImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_id")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ApplyId { get; set; }

                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public int State { get; set; }

                /// <summary>
                /// 获取或设置审核结果描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_desc")]
                public string? AuditDescription { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置当前生效的图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_url")]
        [System.Text.Json.Serialization.JsonPropertyName("img_url")]
        public string ImageUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置最近一次申请信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply")]
        [System.Text.Json.Serialization.JsonPropertyName("apply")]
        public Types.Apply? Apply { get; set; }
    }
}
