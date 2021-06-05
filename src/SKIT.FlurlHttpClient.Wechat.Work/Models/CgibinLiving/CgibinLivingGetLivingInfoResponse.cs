using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/living/get_living_info 接口的响应。</para>
    /// </summary>
    public class CgibinLivingGetLivingInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Living
            {
                /// <summary>
                /// 获取或设置直播 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("livingid")]
                [System.Text.Json.Serialization.JsonPropertyName("livingid")]
                public string LivingId { get; set; } = default!;

                /// <summary>
                /// 获取或设置主播成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("anchor_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("anchor_userid")]
                public string AnchorUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置主播所在主部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("main_department")]
                [System.Text.Json.Serialization.JsonPropertyName("main_department")]
                public int? AnchorMainDepartmentId { get; set; }

                /// <summary>
                /// 获取或设置直播标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("theme")]
                [System.Text.Json.Serialization.JsonPropertyName("theme")]
                public string Theme { get; set; } = default!;

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
                /// 获取或设置预约直播开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reserve_start")]
                [System.Text.Json.Serialization.JsonPropertyName("reserve_start")]
                public long ReserveStartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置预约直播持续时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reserve_living_duration")]
                [System.Text.Json.Serialization.JsonPropertyName("reserve_living_duration")]
                public int ReserveDuration { get; set; }

                /// <summary>
                /// 获取或设置直播类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置直播状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置直播简介。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否开启回放。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_replay")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("open_replay")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedBooleanConverter))]
                public bool IsOpenReplay { get; set; }

                /// <summary>
                /// 获取或设置回放状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("replay_status")]
                [System.Text.Json.Serialization.JsonPropertyName("replay_status")]
                public int? ReplayStatus { get; set; }

                /// <summary>
                /// 获取或设置预约人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subscribe_count")]
                [System.Text.Json.Serialization.JsonPropertyName("subscribe_count")]
                public int SubscribeCount { get; set; }

                /// <summary>
                /// 获取或设置观众总人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("viewer_num")]
                [System.Text.Json.Serialization.JsonPropertyName("viewer_num")]
                public int ViewerCount { get; set; }

                /// <summary>
                /// 获取或设置当前在线观看人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("online_count")]
                [System.Text.Json.Serialization.JsonPropertyName("online_count")]
                public int OnlineViewerCount { get; set; }

                /// <summary>
                /// 获取或设置评论数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comment_num")]
                [System.Text.Json.Serialization.JsonPropertyName("comment_num")]
                public int CommentCount { get; set; }

                /// <summary>
                /// 获取或设置连麦人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mic_num")]
                [System.Text.Json.Serialization.JsonPropertyName("mic_num")]
                public int MicCount { get; set; }

                /// <summary>
                /// 获取或设置推流地址 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("push_stream_url")]
                [System.Text.Json.Serialization.JsonPropertyName("push_stream_url")]
                public string? PushStreamUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置直播信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("living_info")]
        [System.Text.Json.Serialization.JsonPropertyName("living_info")]
        public Types.Living Living { get; set; } = default!;
    }
}
