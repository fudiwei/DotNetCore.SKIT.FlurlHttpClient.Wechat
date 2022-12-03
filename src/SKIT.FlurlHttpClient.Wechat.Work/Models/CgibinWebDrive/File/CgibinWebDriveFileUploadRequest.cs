namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_upload 接口的请求。</para>
    /// </summary>
    public class CgibinWebDriveFileUploadRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置 JSAPI 返回的 SelectedTicket。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("selected_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("selected_ticket")]
        public string? SelectedTicket { get; set; }

        /// <summary>
        /// 获取或设置空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spaceid")]
        [System.Text.Json.Serialization.JsonPropertyName("spaceid")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// 获取或设置上级文件 ID 或空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fatherid")]
        [System.Text.Json.Serialization.JsonPropertyName("fatherid")]
        public string? ParentFileOrSpaceId { get; set; }

        /// <summary>
        /// 获取或设置文件名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_name")]
        [System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string FileName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置经过 Base64 编码的文件内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_base64_content")]
        [System.Text.Json.Serialization.JsonPropertyName("file_base64_content")]
        public string EncodingFileContent { get; set; } = string.Empty;
    }
}
