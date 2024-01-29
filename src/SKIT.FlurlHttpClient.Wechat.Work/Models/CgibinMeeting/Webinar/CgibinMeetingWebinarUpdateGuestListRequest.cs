using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/update_guest_list 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingWebinarUpdateGuestListRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Guest
            {
                /// <summary>
                /// 获取或设置嘉宾类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guest_type")]
                [System.Text.Json.Serialization.JsonPropertyName("guest_type")]
                public int GuestType { get; set; }

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
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string? AreaCode { get; set; }

                /// <summary>
                /// 获取或设置电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_number")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                public string? PhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置电子邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("email")]
                [System.Text.Json.Serialization.JsonPropertyName("email")]
                public string? Email { get; set; }

                /// <summary>
                /// 获取或设置会议嘉宾姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guest_name")]
                [System.Text.Json.Serialization.JsonPropertyName("guest_name")]
                public string? GuestName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置嘉宾列表。。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guests")]
        [System.Text.Json.Serialization.JsonPropertyName("guests")]
        public IList<Types.Guest> GuestList { get; set; } = new List<Types.Guest>();
    }
}
