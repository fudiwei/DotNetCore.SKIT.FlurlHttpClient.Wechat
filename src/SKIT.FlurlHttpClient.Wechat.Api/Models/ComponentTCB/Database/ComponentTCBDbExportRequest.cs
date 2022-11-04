namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/dbexport 接口的请求。</para>
    /// </summary>
    public class ComponentTCBDbExportRequest : WechatApiRequest, IInferable<ComponentTCBDbExportRequest, ComponentTCBDbExportResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

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
        /// 获取或设置导出查询语句。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query")]
        [System.Text.Json.Serialization.JsonPropertyName("query")]
        public string QueryString { get; set; } = string.Empty;
    }
}
