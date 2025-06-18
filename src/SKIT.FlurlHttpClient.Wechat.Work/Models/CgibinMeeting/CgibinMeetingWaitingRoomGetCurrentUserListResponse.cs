namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/waitingroom/get_current_user_list 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingWaitingRoomGetCurrentUserListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class User
            {
                /// <summary>
                /// 获取或设置参与者成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置参与者临时 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmp_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("tmp_openid")]
                public string? TempOpenId { get; set; }

                /// <summary>
                /// 获取或设置终端设备类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("instance_id")]
                [System.Text.Json.Serialization.JsonPropertyName("instance_id")]
                public int InstanceId { get; set; }

                /// <summary>
                /// 获取或设置专属参会链接用户自定义数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customer_data")]
                [System.Text.Json.Serialization.JsonPropertyName("customer_data")]
                public string? CustomData { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置等候室人员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
        public Types.User[] UserList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
