using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/get_info 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingGetInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Attendee
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
                        /// 获取或设置参与者与会状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }

                    public class ExternalUser
                    {
                        /// <summary>
                        /// 获取或设置参与者外部联系人账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("external_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                        public string ExternalUserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置参与者与会状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }

                    public class Device
                    {
                        /// <summary>
                        /// 获取或设置设备序列号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("device_sn")]
                        [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
                        public string DeviceSerialNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置设备与会状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置参与者成员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member")]
                [System.Text.Json.Serialization.JsonPropertyName("member")]
                public Types.User[] UserList { get; set; } = default!;

                /// <summary>
                /// 获取或设置参与者外部联系人列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_user")]
                [System.Text.Json.Serialization.JsonPropertyName("external_user")]
                public Types.ExternalUser[] ExternalUserList { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device")]
                [System.Text.Json.Serialization.JsonPropertyName("device")]
                public Types.Device[] DeviceList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = default!;

        /// <summary>
        /// 获取或设置发起者成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("creator_userid")]
        public string CreatorUserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置发起者所在主部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_department")]
        [System.Text.Json.Serialization.JsonPropertyName("main_department")]
        public int? CreatorMainDepartmentId { get; set; }

        /// <summary>
        /// 获取或设置会议标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置会议开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_start")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_start")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置会议持续时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_duration")]
        public int Duration { get; set; }

        /// <summary>
        /// 获取或设置会议预约开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reserve_meeting_start")]
        [System.Text.Json.Serialization.JsonPropertyName("reserve_meeting_start")]
        public long ReserveStartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置会议预约持续时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reserve_meeting_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("reserve_meeting_duration")]
        public int ReserveDuration { get; set; }

        /// <summary>
        /// 获取或设置会议类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置会议状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置会议描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 获取或设置会议开始前多久提醒（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remind_time")]
        [System.Text.Json.Serialization.JsonPropertyName("remind_time")]
        public int RemindBeforeEventTime { get; set; }

        /// <summary>
        /// 获取或设置参与者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendees")]
        [System.Text.Json.Serialization.JsonPropertyName("attendees")]
        public Types.Attendee Attendee { get; set; } = default!;
    }
}
