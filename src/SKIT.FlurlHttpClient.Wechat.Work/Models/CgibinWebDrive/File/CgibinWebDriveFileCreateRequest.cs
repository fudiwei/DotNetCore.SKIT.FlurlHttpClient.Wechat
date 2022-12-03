namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_create 接口的请求。</para>
    /// </summary>
    public class CgibinWebDriveFileCreateRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spaceid")]
        [System.Text.Json.Serialization.JsonPropertyName("spaceid")]
        public string SpaceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上级文件 ID 或空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fatherid")]
        [System.Text.Json.Serialization.JsonPropertyName("fatherid")]
        public string ParentFileOrSpaceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_type")]
        [System.Text.Json.Serialization.JsonPropertyName("file_type")]
        public int FileType { get; set; }

        /// <summary>
        /// 获取或设置文件名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_name")]
        [System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string FileName { get; set; } = string.Empty;
    }
}
