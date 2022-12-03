namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_rename 接口的请求。</para>
    /// </summary>
    public class CgibinWedriveFileRenameRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fileid")]
        [System.Text.Json.Serialization.JsonPropertyName("fileid")]
        public string FileId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置新的文件名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_name")]
        [System.Text.Json.Serialization.JsonPropertyName("new_name")]
        public string FileName { get; set; } = string.Empty;
    }
}
