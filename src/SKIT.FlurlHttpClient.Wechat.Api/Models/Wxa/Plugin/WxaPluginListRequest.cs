namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/plugin?action=list 接口的请求。</para>
    /// </summary>
    public class WxaPluginListRequest : WechatApiRequest, IInferable<WxaPluginListRequest, WxaPluginListResponse>
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// <para>默认值："list"</para>
        /// <remarks><i>（使用默认值即可，无需修改）</i></remarks>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; } = "list";
    }
}
