using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getstatistics 接口的请求。</para>
    /// </summary>
    public class TcbGetStatisticsRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Condition
            {
                /// <summary>
                /// 获取或设置环境 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env_id")]
                [System.Text.Json.Serialization.JsonPropertyName("env_id")]
                public string? EnvironmentId { get; set; }

                /// <summary>
                /// 获取或设置活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_id")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                public string? ActivityId { get; set; }

                /// <summary>
                /// 获取或设置是否按渠道划分。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("by_channel_id")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("by_channel_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
                public bool? IsByChannelId { get; set; }

                /// <summary>
                /// 获取或设置渠道 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel_id")]
                [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
                public string? ChanneId { get; set; }

                /// <summary>
                /// 获取或设置行为数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("act_type")]
                [System.Text.Json.Serialization.JsonPropertyName("act_type")]
                public string? ActionType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置获取动作。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_date")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_date")]
        public long BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_offset")]
        [System.Text.Json.Serialization.JsonPropertyName("page_offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_limit")]
        [System.Text.Json.Serialization.JsonPropertyName("page_limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置查询条件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("condition")]
        [System.Text.Json.Serialization.JsonPropertyName("condition")]
        public Types.Condition? Condition { get; set; }
    }
}
