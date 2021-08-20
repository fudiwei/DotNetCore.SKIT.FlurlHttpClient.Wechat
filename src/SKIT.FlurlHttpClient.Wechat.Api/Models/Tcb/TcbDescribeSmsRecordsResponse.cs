using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/describesmsrecords 接口的响应。</para>
    /// </summary>
    public class TcbDescribeSmsRecordsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SmsRecord
                    {
                        /// <summary>
                        /// 获取或设置手机号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Mobile")]
                        [System.Text.Json.Serialization.JsonPropertyName("Mobile")]
                        public string MobileNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置短信内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Content")]
                        [System.Text.Json.Serialization.JsonPropertyName("Content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置短信内容长度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ContentSize")]
                        [System.Text.Json.Serialization.JsonPropertyName("ContentSize")]
                        public int ContentSize { get; set; }

                        /// <summary>
                        /// 获取或设置计费条数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("Fee")]
                        public int Fee { get; set; }

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Status")]
                        [System.Text.Json.Serialization.JsonPropertyName("Status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户接收时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ReceivedTime")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("ReceivedTime")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? ReceivedTime { get; set; }

                        /// <summary>
                        /// 获取或设置发送时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("CreateTime")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("CreateTime")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset CreateTime { get; set; }

                        /// <summary>
                        /// 获取或设置备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Remarks")]
                        [System.Text.Json.Serialization.JsonPropertyName("Remarks")]
                        public string? Remark { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置发送记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("SmsRecords")]
                [System.Text.Json.Serialization.JsonPropertyName("SmsRecords")]
                public Types.SmsRecord[] SmsRecordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总记录数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("TotalCount")]
                [System.Text.Json.Serialization.JsonPropertyName("TotalCount")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置唯一请求 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("RequestId")]
                [System.Text.Json.Serialization.JsonPropertyName("RequestId")]
                public string RequestId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置响应数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Response")]
        [System.Text.Json.Serialization.JsonPropertyName("Response")]
        public Types.Data Data { get; set; } = default!;
    }
}
