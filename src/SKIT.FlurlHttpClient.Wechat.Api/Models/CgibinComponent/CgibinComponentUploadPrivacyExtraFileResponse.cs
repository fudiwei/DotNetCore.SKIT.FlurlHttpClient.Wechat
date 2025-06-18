namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/uploadprivacyextfile 接口的响应。</para>
    /// </summary>
    public class CgibinComponentUploadPrivacyExtraFileResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置用户隐私保护指引文件的 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_file_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_file_media_id")]
        public string ExtraFileMediaId { get; set; } = default!;
    }
}
