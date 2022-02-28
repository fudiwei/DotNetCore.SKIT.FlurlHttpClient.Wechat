namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/bind_tester 接口的请求。</para>
    /// </summary>
    public class WxaBindTesterRequest : WechatApiRequest, IInferable<WxaBindTesterRequest, WxaBindTesterResponse>
    {
        /// <summary>
        /// 获取或设置体验者微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wechatid")]
        [System.Text.Json.Serialization.JsonPropertyName("wechatid")]
        public string Wxname { get; set; } = string.Empty;
    }
}
