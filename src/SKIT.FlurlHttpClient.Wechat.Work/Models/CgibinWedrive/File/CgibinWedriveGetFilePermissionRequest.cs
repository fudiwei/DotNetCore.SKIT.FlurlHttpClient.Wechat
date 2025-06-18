namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/get_file_permission 接口的请求。</para>
    /// </summary>
    public class CgibinWedriveGetFilePermissionRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fileid")]
        [System.Text.Json.Serialization.JsonPropertyName("fileid")]
        public string FileId { get; set; } = string.Empty;
    }
}
