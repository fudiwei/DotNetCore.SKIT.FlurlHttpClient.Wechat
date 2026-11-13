namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/topic/get_topic_member_list 接口的响应。</para>
    /// </summary>
    public class CgibinAIBotTopicGetTopicMemberListResponse : WechatWorkAIBotResponse
    {
        public static class Types
        {
            public class Member : CgibinAIBotTopicSearchRequest.Types.Member
            {
            }
        }

        /// <summary>
        /// 获取或设置成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("member_list")]
        [System.Text.Json.Serialization.JsonPropertyName("member_list")]
        public Types.Member[]? MemberList { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置下一页分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
