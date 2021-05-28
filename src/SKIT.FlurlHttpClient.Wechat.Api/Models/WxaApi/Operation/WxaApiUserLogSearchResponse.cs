using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/userlog/userlog_search 接口的响应。</para>
    /// </summary>
    public class WxaApiUserLogSearchResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class RealtimeLog
                    {
                        public static class Types
                        {
                            public class Message
                            {
                                /// <summary>
                                /// 获取或设置日志等级。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("level")]
                                [System.Text.Json.Serialization.JsonPropertyName("level")]
                                public int LogLevel { get; set; }

                                /// <summary>
                                /// 获取或设置日志内容列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("msg")]
                                [System.Text.Json.Serialization.JsonPropertyName("msg")]
                                public string[] MessageList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置日志时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time")]
                                [System.Text.Json.Serialization.JsonPropertyName("time")]
                                public long Timestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置日志等级。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("level")]
                        [System.Text.Json.Serialization.JsonPropertyName("level")]
                        public int LogLevel { get; set; }

                        /// <summary>
                        /// 获取或设置基础库版本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("libraryVersion")]
                        [System.Text.Json.Serialization.JsonPropertyName("libraryVersion")]
                        public string SdkVersion { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置客户端版本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("clientVersion")]
                        [System.Text.Json.Serialization.JsonPropertyName("clientVersion")]
                        public string ClientVersion { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置平台类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform")]
                        public int Platform { get; set; }

                        /// <summary>
                        /// 获取或设置小程序启动的唯一 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("traceid")]
                        [System.Text.Json.Serialization.JsonPropertyName("traceid")]
                        public string TraceId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string PagePath { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置过滤字段。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("filterMsg")]
                        [System.Text.Json.Serialization.JsonPropertyName("filterMsg")]
                        public string? FilterMessage { get; set; }

                        /// <summary>
                        /// 获取或设置日志内容列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg")]
                        public Types.Message[] MessageList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置日志时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("timestamp")]
                        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
                        public long Timestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置实时日志列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.RealtimeLog[] RealtimeLogList { get; set; } = default!;

                /// <summary>
                /// 获取或设置实时日志总条数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int Total { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置实时日志数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
