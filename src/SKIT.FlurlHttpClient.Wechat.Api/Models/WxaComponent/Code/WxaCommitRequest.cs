namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/commit 接口的请求。</para>
    /// </summary>
    public class WxaCommitRequest : WechatApiRequest, IMapResponse<WxaCommitRequest, WxaCommitResponse>
    {
        /// <summary>
        /// 获取或设置代码模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 JSON 格式的扩展参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_json")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_json")]
        public string JsonExtra { get; set; } = "{}";

        /// <summary>
        /// 获取或设置用户自定义版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_version")]
        [System.Text.Json.Serialization.JsonPropertyName("user_version")]
        public string UserVersion { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户自定义版本描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
        public string UserDescription { get; set; } = string.Empty;
    }
}
