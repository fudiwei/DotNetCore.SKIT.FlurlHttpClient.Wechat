using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/advanced_layout/apply 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingAdvancedLayoutApplyRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class User
            {
                /// <summary>
                /// 获取或设置参会的成员临时 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmp_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("tmp_openid")]
                public string TempOpenId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置布局 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("layout_id")]
        [System.Text.Json.Serialization.JsonPropertyName("layout_id")]
        public string LayoutId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
        public IList<Types.User> UserList { get; set; } = new List<Types.User>();
    }
}
