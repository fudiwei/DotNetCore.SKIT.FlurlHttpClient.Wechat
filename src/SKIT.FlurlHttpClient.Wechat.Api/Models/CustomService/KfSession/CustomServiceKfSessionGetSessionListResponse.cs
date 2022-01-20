namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /customservice/kfsession/getsessionlist 接口的响应。</para>
    /// </summary>
    public class CustomServiceKfSessionGetSessionListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Session
            {
                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置会话接入的时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("createtime")]
                [System.Text.Json.Serialization.JsonPropertyName("createtime")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置客服会话列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sessionlist")]
        [System.Text.Json.Serialization.JsonPropertyName("sessionlist")]
        public Types.Session[] SessionList { get; set; } = default!;
    }
}
