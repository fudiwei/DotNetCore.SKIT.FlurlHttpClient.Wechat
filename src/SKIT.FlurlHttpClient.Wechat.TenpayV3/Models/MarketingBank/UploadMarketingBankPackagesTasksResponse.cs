using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/bank/packages/{package_id}/tasks 接口的响应。</para>
    /// </summary>
    public class UploadMarketingBankPackagesTasksResponse : WechatTenpayResponse
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
        /// 获取或设置银行类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置银行类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? UpdateTime { get; set; }
    }
}
