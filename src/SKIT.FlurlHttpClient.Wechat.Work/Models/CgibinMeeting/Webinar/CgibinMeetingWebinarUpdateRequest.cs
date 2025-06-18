using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/update 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingWebinarUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Host : CgibinMeetingWebinarCreateRequest.Types.Host
            {
            }

            public class MediaSettings : CgibinMeetingWebinarCreateRequest.Types.MediaSettings
            {
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议主题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置主办方名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sponsor")]
        [System.Text.Json.Serialization.JsonPropertyName("sponsor")]
        public string? Sponsor { get; set; }

        /// <summary>
        /// 获取或设置会议开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置会议结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置主持人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hosts")]
        [System.Text.Json.Serialization.JsonPropertyName("hosts")]
        public IList<Types.Host>? HostList { get; set; }

        /// <summary>
        /// 获取或设置观众观看限制类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admission_type")]
        [System.Text.Json.Serialization.JsonPropertyName("admission_type")]
        public int AdmissionType { get; set; }

        /// <summary>
        /// 获取或设置观众观看密码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("password")]
        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 获取或设置封面图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_url")]
        [System.Text.Json.Serialization.JsonPropertyName("cover_url")]
        public string? CoverUrl { get; set; }

        /// <summary>
        /// 获取或设置会议描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置是否开启通过邀请链接自动成为嘉宾。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_guest_invite_link")]
        [System.Text.Json.Serialization.JsonPropertyName("enable_guest_invite_link")]
        public bool? EnableGuestInviteLink { get; set; }

        /// <summary>
        /// 获取或设置媒体参数配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_setting")]
        [System.Text.Json.Serialization.JsonPropertyName("media_setting")]
        public Types.MediaSettings? MediaSettings { get; set; }

        /// <summary>
        /// 获取或设置是否开启问答。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_qa")]
        [System.Text.Json.Serialization.JsonPropertyName("enable_qa")]
        public bool? EnableQA { get; set; }

        /// <summary>
        /// 获取或设置聊天敏感词列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sensitive_words")]
        [System.Text.Json.Serialization.JsonPropertyName("sensitive_words")]
        public IList<string>? SensitiveWordList { get; set; }

        /// <summary>
        /// 获取或设置是否开启人工审核。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_manual_check")]
        [System.Text.Json.Serialization.JsonPropertyName("enable_manual_check")]
        public bool? EnableManualCheck { get; set; }

        /// <summary>
        /// 获取或设置是否开启活动页。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_page")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_page")]
        public bool? EnableActivityPage { get; set; }

        /// <summary>
        /// 获取或设置活动页展示已报名或已预约人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("display_number_of_attendees")]
        [System.Text.Json.Serialization.JsonPropertyName("display_number_of_attendees")]
        public int? DisplayNumberOfAttendeesType { get; set; }

        /// <summary>
        /// 获取或设置是否允许观众观看回放。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("playback_for_audience")]
        [System.Text.Json.Serialization.JsonPropertyName("playback_for_audience")]
        public bool? AllowPlaybackForAudience { get; set; }

        /// <summary>
        /// 获取或设置是否开启准备模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("preparation_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("preparation_mode")]
        public bool? EnablePreparationMode { get; set; }
    }
}
