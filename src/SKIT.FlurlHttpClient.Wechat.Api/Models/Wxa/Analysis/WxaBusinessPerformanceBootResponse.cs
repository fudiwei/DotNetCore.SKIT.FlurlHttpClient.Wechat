using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/performance/boot 接口的响应。</para>
    /// </summary>
    public class WxaBusinessPerformanceBootResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Body
                    {
                        public static class Types
                        {
                            public class Table
                            {
                                public static class Types
                                {
                                    public class Line
                                    {
                                        public static class Types
                                        {
                                            public class Field
                                            {
                                                /// <summary>
                                                /// 获取或设置数据的日期（格式：yyyyMMdd）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("refdate")]
                                                [System.Text.Json.Serialization.JsonPropertyName("refdate")]
                                                public string RefDateString { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置性能数据值。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("value")]
                                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                                public string Value { get; set; } = default!;
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置单天的性能数据列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("fields")]
                                        [System.Text.Json.Serialization.JsonPropertyName("fields")]
                                        public Types.Field[] FieldList { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置性能数据指标 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string Id { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置性能数据指标名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("zh")]
                                [System.Text.Json.Serialization.JsonPropertyName("zh")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置按时间排列的性能数据列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("lines")]
                                [System.Text.Json.Serialization.JsonPropertyName("lines")]
                                public Types.Line[] LineList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置性能数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tables")]
                        [System.Text.Json.Serialization.JsonPropertyName("tables")]
                        public Types.Table[] TableList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置性能数据条数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置性能数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("body")]
                [System.Text.Json.Serialization.JsonPropertyName("body")]
                public Types.Body Body { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
