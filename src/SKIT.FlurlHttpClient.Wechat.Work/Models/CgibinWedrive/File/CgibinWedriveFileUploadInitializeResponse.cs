namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_upload_init 接口的响应。</para>
    /// </summary>
    public class CgibinWedriveFileUploadInitializeResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置是否命中秒传。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hit_exist")]
        [System.Text.Json.Serialization.JsonPropertyName("hit_exist")]
        public bool IsHitExist { get; set; }

        /// <summary>
        /// 获取或设置上传凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_key")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_key")]
        public string? UploadKey { get; set; }

        /// <summary>
        /// 获取或设置文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fileid")]
        [System.Text.Json.Serialization.JsonPropertyName("fileid")]
        public string? FileId { get; set; }
    }
}
