namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databasemigrateexport 接口的响应。</para>
    /// </summary>
    public class TcbDatabaseMigrateExportResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置导出任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job_id")]
        [System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int JobId { get; set; }
    }
}
