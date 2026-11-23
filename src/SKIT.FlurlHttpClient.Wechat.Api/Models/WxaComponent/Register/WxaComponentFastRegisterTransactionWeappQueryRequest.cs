namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/component/fastregistertransactionweapp?action=query 接口的请求。</para>
    /// </summary>
    public class WxaComponentFastRegisterTransactionWeappQueryRequest : WechatApiRequest, IInferable<WxaComponentFastRegisterTransactionWeappQueryRequest, WxaComponentFastRegisterTransactionWeappQueryResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAccessToken { get; set; }

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
