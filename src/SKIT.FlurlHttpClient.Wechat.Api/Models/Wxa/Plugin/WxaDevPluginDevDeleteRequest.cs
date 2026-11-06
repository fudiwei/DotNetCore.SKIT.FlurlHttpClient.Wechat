namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/devplugin?action=dev_delete 接口的请求。</para>
    /// </summary>
    public class WxaDevPluginDevDeleteRequest : WechatApiRequest, IInferable<WxaDevPluginDevDeleteRequest, WxaDevPluginDevDeleteResponse>
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// <para>默认值："dev_delete"</para>
        /// <remarks><i>（使用默认值即可，无需修改）</i></remarks>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; } = "dev_delete";
    }
}
