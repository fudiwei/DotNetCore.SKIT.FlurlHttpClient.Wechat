namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_unassigned_list 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetUnassignedListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class DismissedUser
            {
                /// <summary>
                /// 获取或设置离职成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("handover_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("handover_userid")]
                public string HandoverUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string ExternalUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置离职时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dimission_time")]
                [System.Text.Json.Serialization.JsonPropertyName("dimission_time")]
                public long DismissionTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置离职成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.DismissedUser[] DismissedUserList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页是否结束。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_last")]
        [System.Text.Json.Serialization.JsonPropertyName("is_last")]
        public bool IsEnding { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
