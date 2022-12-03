namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_download 接口的请求。</para>
    /// </summary>
    public class CgibinWebDriveFileDownloadRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置 JSAPI 返回的 SelectedTicket。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("selected_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("selected_ticket")]
        public string? SelectedTicket { get; set; }

        /// <summary>
        /// 获取或设置文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fileid")]
        [System.Text.Json.Serialization.JsonPropertyName("fileid")]
        public string? FileId { get; set; }
    }
}
