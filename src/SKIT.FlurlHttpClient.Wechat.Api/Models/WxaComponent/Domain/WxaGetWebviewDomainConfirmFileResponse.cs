namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/get_webviewdomain_confirmfile 接口的响应。</para>
    /// </summary>
    public class WxaGetWebviewDomainConfirmFileResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置文件名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_name")]
        [System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// 获取或设置文件内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_content")]
        [System.Text.Json.Serialization.JsonPropertyName("file_content")]
        public string FileContent { get; set; } = default!;
    }
}
