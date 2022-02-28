namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/changewxasearchstatus 接口的请求。</para>
    /// </summary>
    public class WxaChangeWxaSearchStatusRequest : WechatApiRequest, IInferable<WxaChangeWxaSearchStatusRequest, WxaChangeWxaSearchStatusResponse>
    {
        /// <summary>
        /// 获取或设置搜索状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int SearchStatus { get; set; }
    }
}
