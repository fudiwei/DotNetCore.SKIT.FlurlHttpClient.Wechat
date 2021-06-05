using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/dial/get_dial_record 接口的响应。</para>
    /// </summary>
    public class CgibinDialogGetDialogRecordResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Record
            {
                public static class Types
                {
                    public class Caller
                    {
                        /// <summary>
                        /// 获取或设置主叫用户的成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置主叫用户的通话时长（单位：分钟）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("duration")]
                        public long Duration { get; set; }
                    }

                    public class Callee
                    {
                        /// <summary>
                        /// 获取或设置被叫用户的成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string? UserId { get; set; }

                        /// <summary>
                        /// 获取或设置被叫用户的号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("phone")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedStringConverter))]
                        public string? PhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置被叫用户的通话时长（单位：分钟）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("duration")]
                        public long? Duration { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置通话类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("call_type")]
                [System.Text.Json.Serialization.JsonPropertyName("call_type")]
                public int CallType { get; set; }

                /// <summary>
                /// 获取或设置拨出时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("call_time")]
                [System.Text.Json.Serialization.JsonPropertyName("call_time")]
                public long CallTimestamp { get; set; }

                /// <summary>
                /// 获取或设置总通话时长（单位：分钟）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_duration")]
                [System.Text.Json.Serialization.JsonPropertyName("total_duration")]
                public int TotalDuration { get; set; }

                /// <summary>
                /// 获取或设置主叫信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("caller")]
                [System.Text.Json.Serialization.JsonPropertyName("caller")]
                public Types.Caller Caller { get; set; } = default!;

                /// <summary>
                /// 获取或设置被叫列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("callee")]
                [System.Text.Json.Serialization.JsonPropertyName("callee")]
                public Types.Callee[] CalleeList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置通话记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record")]
        [System.Text.Json.Serialization.JsonPropertyName("record")]
        public Types.Record[] RecordList { get; set; } = default!;
    }
}
