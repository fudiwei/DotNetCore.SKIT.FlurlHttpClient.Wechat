namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/component/fastnormalizebetaweapp?action=query 接口的请求。</para>
    /// </summary>
    public class WxaComponentFastNormalizeBetaWeappQueryRequest : WechatApiRequest, IInferable<WxaComponentFastNormalizeBetaWeappQueryRequest, WxaComponentFastNormalizeBetaWeappQueryResponse>
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("taskid")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 获取或设置是否使用新接口。
        /// <para>默认值：true</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_version")]
        [System.Text.Json.Serialization.JsonPropertyName("new_version")]
        public bool? IsNewVersion { get; set; } = true;
    }
}
