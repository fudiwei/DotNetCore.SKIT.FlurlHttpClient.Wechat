using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /custom_audience_files/get 接口的响应。</para>
    /// </summary>
    public class CustomAudienceFilesGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CustomAudienceFile
                    {
                        /// <summary>
                        /// 获取或设置自定义人群 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audience_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("audience_id")]
                        public int CustomAudienceId { get; set; }

                        /// <summary>
                        /// 获取或设置自定义人群数据文件 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_audience_file_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_audience_file_id")]
                        public int CustomAudienceFileId { get; set; }

                        /// <summary>
                        /// 获取或设置自定义人群数据文件名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string CustomAudienceFileName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户 ID 类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_id_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_id_type")]
                        public string UserIdType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文件操作类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operation_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("operation_type")]
                        public string OperationType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置处理状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("process_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("process_status")]
                        public string ProcessStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("process_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("process_code")]
                        public int ErrorCode { get; set; }

                        /// <summary>
                        /// 获取或设置错误信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("error_message")]
                        [System.Text.Json.Serialization.JsonPropertyName("error_message")]
                        public string? ErrorMessage { get; set; }

                        /// <summary>
                        /// 获取或设置文件总行数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("line_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("line_count")]
                        public int LineCount { get; set; }

                        /// <summary>
                        /// 获取或设置文件包含的有效行数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_line_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_line_count")]
                        public int ValidLineCount { get; set; }

                        /// <summary>
                        /// 获取或设置文件包含的用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_count")]
                        public int UserCount { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("created_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("created_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset CreateTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置自定义人群数据文件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.CustomAudienceFile[] CustomAudienceFileList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public Abstractions.CommonPagination Pagination { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
