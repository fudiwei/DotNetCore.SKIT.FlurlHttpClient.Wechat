namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/export/create_job 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataExportCreateJobRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会话展示组件的 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string TaskType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置导出内容的模板文件素材 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = string.Empty;
    }
}
