namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/file_upload_init 接口的响应。</para>
    /// </summary>
    public class CgibinWedocFileUploadInitResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置是否命中秒传。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hit_exist")]
        [System.Text.Json.Serialization.JsonPropertyName("hit_exist")]
        public bool IsHitExist { get; set; }

        /// <summary>
        /// 获取或设置文件上传凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_key")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_key")]
        public string? UploadKey { get; set; }

        /// <summary>
        /// 获取或设置文件 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_url")]
        [System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }
    }
}
