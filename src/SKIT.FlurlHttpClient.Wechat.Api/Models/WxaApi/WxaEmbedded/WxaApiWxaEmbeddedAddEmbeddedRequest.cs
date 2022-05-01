namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/wxaembedded/add_embedded 接口的请求。</para>
    /// </summary>
    public class WxaApiWxaEmbeddedAddEmbeddedRequest : WechatApiRequest, IInferable<WxaApiWxaEmbeddedAddEmbeddedRequest, WxaApiWxaEmbeddedAddEmbeddedResponse>
    {
        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置申请理由。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_reason")]
        public string? ApplyReason { get; set; }
    }
}
