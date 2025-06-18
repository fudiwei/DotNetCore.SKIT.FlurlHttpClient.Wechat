namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/getagreestatus/room 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataGetAgreeStatusRoomResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class AgreeInfo
            {
                /// <summary>
                /// 获取或设置外部成员 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string ExteranalUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置同意情况。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agree_status")]
                [System.Text.Json.Serialization.JsonPropertyName("agree_status")]
                public string AgreeStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态改变时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status_change_time")]
                [System.Text.Json.Serialization.JsonPropertyName("status_change_time")]
                public long ChangeTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会话同意情况列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agreeinfo")]
        [System.Text.Json.Serialization.JsonPropertyName("agreeinfo")]
        public Types.AgreeInfo[] AgreeInfoList { get; set; } = default!;
    }
}
