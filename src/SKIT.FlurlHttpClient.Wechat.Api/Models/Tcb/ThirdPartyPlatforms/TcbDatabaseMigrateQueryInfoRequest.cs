using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databasemigratequeryinfo 接口的请求。</para>
    /// </summary>
    public class TcbDatabaseMigrateQueryInfoRequest : WechatApiRequest, IMapResponse<TcbDatabaseMigrateQueryInfoRequest, TcbDatabaseMigrateQueryInfoResponse>
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job_id")]
        [System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int JobId { get; set; }
    }
}
