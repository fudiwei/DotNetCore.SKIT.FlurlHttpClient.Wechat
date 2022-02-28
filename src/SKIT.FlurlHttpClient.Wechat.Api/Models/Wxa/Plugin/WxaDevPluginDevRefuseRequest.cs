namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/devplugin?action=dev_refuse 接口的请求。</para>
    /// </summary>
    public class WxaDevPluginDevRefuseRequest : WechatApiRequest, IInferable<WxaDevPluginDevRefuseRequest, WxaDevPluginDevRefuseResponse>
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "dev_refuse";

        /// <summary>
        /// 获取或设置拒绝申请的理由。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string Reason { get; set; } = string.Empty;
    }
}
