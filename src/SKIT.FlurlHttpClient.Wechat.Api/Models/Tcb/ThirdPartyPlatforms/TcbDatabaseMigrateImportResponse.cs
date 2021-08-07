using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databasemigrateimport 接口的响应。</para>
    /// </summary>
    public class TcbDatabaseMigrateImportResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置导入任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job_id")]
        [System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int JobId { get; set; }
    }
}
