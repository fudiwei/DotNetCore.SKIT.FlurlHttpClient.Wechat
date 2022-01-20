using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/living/create 接口的请求。</para>
    /// </summary>
    public class CgibinLivingCreateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class ActivityDetail
            {
                /// <summary>
                /// 获取或设置活动直播简介。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置活动直播附图 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_list")]
                [System.Text.Json.Serialization.JsonPropertyName("image_list")]
                public IList<string>? ImageMediaIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置主播成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anchor_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("anchor_userid")]
        public string AnchorUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置直播标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("theme")]
        [System.Text.Json.Serialization.JsonPropertyName("theme")]
        public string Theme { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置直播开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("living_start")]
        [System.Text.Json.Serialization.JsonPropertyName("living_start")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置直播持续时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("living_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("living_duration")]
        public int Duration { get; set; }

        /// <summary>
        /// 获取或设置直播类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置直播简介。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置直播开始前多久提醒（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remind_time")]
        [System.Text.Json.Serialization.JsonPropertyName("remind_time")]
        public int? RemindBeforeEventTime { get; set; }

        /// <summary>
        /// 获取或设置直播间封面 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_cover_mediaid")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_cover_mediaid")]
        public string? ActivityCoverMediaId { get; set; }

        /// <summary>
        /// 获取或设置直播间分享图片 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_share_mediaid")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_share_mediaid")]
        public string? ActivitySharePictureMediaId { get; set; }

        /// <summary>
        /// 获取或设置活动直播详情信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_detail")]
        public Types.ActivityDetail? ActivityDetail { get; set; }

        /// <summary>
        /// 获取或设置授权方安装的应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }
    }
}
