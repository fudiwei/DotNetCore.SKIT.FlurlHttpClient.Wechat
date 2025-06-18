namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/get_user_notify 接口的响应。</para>
    /// </summary>
    public class WxaGetUserNotifyResponse : WechatApiResponse
    {
        public static class Types
        {
            public class NotifyInfo
            {
                /// <summary>
                /// 获取或设置卡片类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notify_type")]
                [System.Text.Json.Serialization.JsonPropertyName("notify_type")]
                public int NotifyType { get; set; }

                /// <summary>
                /// 获取或设置通知状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code_state")]
                [System.Text.Json.Serialization.JsonPropertyName("code_state")]
                public int CodeState { get; set; }

                /// <summary>
                /// 获取或设置通知过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code_expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("code_expire_time")]
                public long CodeExpireTimestamp { get; set; } 

                /// <summary>
                /// 获取或设置卡片状态与状态相关字段 JSON 数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content_json")]
                [System.Text.Json.Serialization.JsonPropertyName("content_json")]
                public string? ContentJson { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务卡片信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_info")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_info")]
        public Types.NotifyInfo NotifyInfo { get; set; } = default!;
    }
}
