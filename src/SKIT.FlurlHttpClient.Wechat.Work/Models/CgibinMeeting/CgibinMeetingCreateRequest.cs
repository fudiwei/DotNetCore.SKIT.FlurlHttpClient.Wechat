using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/create 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingCreateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Attendee
            {
                /// <summary>
                /// 获取或设置参与者成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public IList<string>? UserIdList { get; set; }

                /// <summary>
                /// 获取或设置参与者外部联系人账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public IList<string>? ExternalUserIdList { get; set; }

                /// <summary>
                /// 获取或设置设备序列号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_sn")]
                [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
                public IList<string>? DeviceSerialNumberList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置发起者成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("creator_userid")]
        public string CreatorUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

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
        /// 获取或设置会议类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置会议描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置会议开始前多久提醒（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remind_time")]
        [System.Text.Json.Serialization.JsonPropertyName("remind_time")]
        public int? RemindBeforeEventTime { get; set; }

        /// <summary>
        /// 获取或设置参与者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendees")]
        [System.Text.Json.Serialization.JsonPropertyName("attendees")]
        public Types.Attendee? Attendee { get; set; }

        /// <summary>
        /// 获取或设置授权方安装的应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }
    }
}
