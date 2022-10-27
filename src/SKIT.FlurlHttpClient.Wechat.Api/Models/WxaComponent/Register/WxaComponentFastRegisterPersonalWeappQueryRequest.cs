namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wx/component/fastregisterpersonalweapp?action=query 接口的请求。</para>
    /// </summary>
    public class WxaComponentFastRegisterPersonalWeappQueryRequest : WechatApiRequest, IInferable<WxaComponentFastRegisterPersonalWeappQueryRequest, WxaComponentFastRegisterPersonalWeappCreateResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("taskid")]
        public string TaskId { get; set; } = string.Empty;
    }
}
