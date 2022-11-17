using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/getscflist 接口的响应。</para>
    /// </summary>
    public class ComponentTCBGetSCFListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Function
            {
                public static class Types
                {
                    public class StatusReason
                    {
                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("errcode")]
                        [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                        public string ErrorCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置错误描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("errmsg")]
                        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                        public string ErrorMessage { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置函数名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string FunctionName { get; set; } = default!;

                /// <summary>
                /// 获取或设置运行时。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("runtime")]
                [System.Text.Json.Serialization.JsonPropertyName("runtime")]
                public string Runtime { get; set; } = default!;

                /// <summary>
                /// 获取或设置函数状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态原因列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("status_reason")]
                public Types.StatusReason[] StatusReasonList { get; set; } = default!;

                /// <summary>
                /// 获取或设置修改时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mod_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("mod_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("add_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("add_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置云函数列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("functions")]
        [System.Text.Json.Serialization.JsonPropertyName("functions")]
        public Types.Function[] FunctionList { get; set; } = default!;

        /// <summary>
        /// 获取或设置云函数总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
