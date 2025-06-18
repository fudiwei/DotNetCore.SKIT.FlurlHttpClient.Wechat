namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/sharer/get_sharer_data_summary 接口的请求。</para>
    /// </summary>
    public class ShopSharerGetSharerDataSummaryRequest : WechatApiRequest, IInferable<ShopSharerGetSharerDataSummaryRequest, ShopSharerGetSharerDataSummaryResponse>
    {
        /// <summary>
        /// 获取或设置分享员 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;
    }
}
