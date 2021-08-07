using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databasemigratequeryinfo 接口的响应。</para>
    /// </summary>
    public class TcbDatabaseMigrateQueryInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置成功记录数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_success")]
        [System.Text.Json.Serialization.JsonPropertyName("record_success")]
        public int SuccessCount { get; set; }

        /// <summary>
        /// 获取或设置失败记录数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_fail")]
        [System.Text.Json.Serialization.JsonPropertyName("record_fail")]
        public int FailCount { get; set; }

        /// <summary>
        /// 获取或设置失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("error_msg")]
        public string? FailReason { get; set; }

        /// <summary>
        /// 获取或设置导出文件下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_url")]
        [System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }
    }
}
