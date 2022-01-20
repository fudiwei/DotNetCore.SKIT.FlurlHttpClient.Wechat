namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/applyliveinfo 接口的请求。</para>
    /// </summary>
    public class WxaBusinessApplyLiveInfoRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置执行动作。
        /// <para>默认值：</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "apply";
    }
}
