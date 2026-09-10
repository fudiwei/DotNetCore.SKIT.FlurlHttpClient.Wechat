namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/file_upload_finish 接口的响应。</para>
    /// </summary>
    public class CgibinWedocFileUploadFinishResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置文件 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_url")]
        [System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string FileUrl { get; set; } = default!;
    }
}
