namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databasemigrateimport 接口的请求。</para>
    /// </summary>
    public class TCBDatabaseMigrateImportRequest : WechatApiRequest, IInferable<TCBDatabaseMigrateImportRequest, TCBDatabaseMigrateImportResponse>
    {
        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置集合名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collection_name")]
        [System.Text.Json.Serialization.JsonPropertyName("collection_name")]
        public string CollectionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置导入文件路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_path")]
        [System.Text.Json.Serialization.JsonPropertyName("file_path")]
        public string FilePath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置导入文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_type")]
        [System.Text.Json.Serialization.JsonPropertyName("file_type")]
        public int FileType { get; set; }

        /// <summary>
        /// 获取或设置是否在遇到错误时停止导入。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stop_on_error")]
        [System.Text.Json.Serialization.JsonPropertyName("stop_on_error")]
        public bool RequireStopOnError { get; set; }

        /// <summary>
        /// 获取或设置冲突处理模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conflict_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("conflict_mode")]
        public int ConflictMode { get; set; }
    }
}
