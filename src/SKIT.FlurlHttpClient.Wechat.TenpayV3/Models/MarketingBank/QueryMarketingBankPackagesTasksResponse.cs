using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/bank/packages/{package_id}/tasks 接口的响应。</para>
    /// </summary>
    public class QueryMarketingBankPackagesTasksResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Task
            {
                /// <summary>
                /// 获取或设置任务上传的文件名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("filename")]
                [System.Text.Json.Serialization.JsonPropertyName("filename")]
                public string FileName { get; set; } = default!;

                /// <summary>
                /// 获取或设置上传任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public string TaskId { get; set; } = default!;

                /// <summary>
                /// 获取或设置号码包 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_id")]
                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                public string PackageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置任务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string? Status { get; set; }

                /// <summary>
                /// 获取或设置银行类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_type")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
                public string? BankType { get; set; }

                /// <summary>
                /// 获取或设置匹配成功的协议号数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_count")]
                [System.Text.Json.Serialization.JsonPropertyName("success_count")]
                public int? SuccessCount { get; set; }

                /// <summary>
                /// 获取或设置匹配失败的协议号数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_count")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_count")]
                public int? FailCount { get; set; }

                /// <summary>
                /// 获取或设置匹配成功的微信用户数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_user_count")]
                [System.Text.Json.Serialization.JsonPropertyName("success_user_count")]
                public int? SuccessUserCount { get; set; }

                /// <summary>
                /// 获取或设置创建类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }

                /// <summary>
                /// 获取或设置最后更新类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? UpdateTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置上传任务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Task[] TaskList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
