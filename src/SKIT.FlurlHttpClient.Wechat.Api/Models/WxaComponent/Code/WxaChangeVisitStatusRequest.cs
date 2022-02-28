namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/change_visitstatus 接口的请求。</para>
    /// </summary>
    public class WxaChangeVisitStatusRequest : WechatApiRequest, IInferable<WxaChangeVisitStatusRequest, WxaChangeVisitStatusResponse>
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// <para>默认值：open</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "open";
    }
}
