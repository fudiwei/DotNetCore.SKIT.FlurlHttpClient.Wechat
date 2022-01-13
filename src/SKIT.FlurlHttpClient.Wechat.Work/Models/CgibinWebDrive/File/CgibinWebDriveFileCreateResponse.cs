namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_create 接口的响应。</para>
    /// </summary>
    public class CgibinWebDriveFileCreateResponse : CgibinWebDriveFileUploadResponse
    {
        /// <summary>
        /// 获取或设置访问链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;
    }
}
