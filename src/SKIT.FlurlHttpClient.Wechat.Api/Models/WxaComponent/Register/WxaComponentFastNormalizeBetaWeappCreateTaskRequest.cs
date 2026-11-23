namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/component/fastnormalizebetaweapp?action=createtask 接口的请求。</para>
    /// </summary>
    public class WxaComponentFastNormalizeBetaWeappCreateTaskRequest : WechatApiRequest, IInferable<WxaComponentFastNormalizeBetaWeappCreateTaskRequest, WxaComponentFastNormalizeBetaWeappCreateTaskResponse>
    {
        /// <summary>
        /// 获取或设置第三方联系电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("component_phone")]
        public string? ComponentPhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置是否使用新接口。
        /// <para>默认值：true</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_version")]
        [System.Text.Json.Serialization.JsonPropertyName("new_version")]
        public bool? IsNewVersion { get; set; } = true;
    }
}
