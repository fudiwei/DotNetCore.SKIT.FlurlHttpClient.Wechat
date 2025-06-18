namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/pstncc/call 接口的响应。</para>
    /// </summary>
    public class CgibinPSTNCCCallResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class CallState
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置呼叫 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("callid")]
                [System.Text.Json.Serialization.JsonPropertyName("callid")]
                public string CallId { get; set; } = default!;

                /// <summary>
                /// 获取或设置呼叫结果状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public int CallCode { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置自动语音来电呼叫状态列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("states")]
        [System.Text.Json.Serialization.JsonPropertyName("states")]
        public Types.CallState[] CallStateList { get; set; } = default!;
    }
}
