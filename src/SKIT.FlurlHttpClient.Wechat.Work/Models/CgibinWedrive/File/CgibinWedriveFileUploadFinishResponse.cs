namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_upload_finish 接口的响应。</para>
    /// </summary>
    public class CgibinWedriveFileUploadFinishResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fileid")]
        [System.Text.Json.Serialization.JsonPropertyName("fileid")]
        public string FileId { get; set; } = default!;
    }
}
