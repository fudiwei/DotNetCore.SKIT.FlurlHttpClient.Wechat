namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_upload_finish 接口的请求。</para>
    /// </summary>
    public class CgibinWedriveFileUploadFinishRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置上传凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_key")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_key")]
        public string UploadKey { get; set; } = string.Empty;
    }
}
