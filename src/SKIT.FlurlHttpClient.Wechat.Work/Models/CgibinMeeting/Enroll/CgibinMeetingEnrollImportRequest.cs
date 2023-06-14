using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/enroll/import 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingEnrollImportRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Enroll
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置国家地区代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("area")]
                [System.Text.Json.Serialization.JsonPropertyName("area")]
                public string? AreaCode { get; set; }

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_number")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                public string? PhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nick_name")]
                [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                public string? Nickname { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置报名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enroll_list")]
        [System.Text.Json.Serialization.JsonPropertyName("enroll_list")]
        public IList<Types.Enroll> EnrollList { get; set; } = new List<Types.Enroll>();
    }
}
