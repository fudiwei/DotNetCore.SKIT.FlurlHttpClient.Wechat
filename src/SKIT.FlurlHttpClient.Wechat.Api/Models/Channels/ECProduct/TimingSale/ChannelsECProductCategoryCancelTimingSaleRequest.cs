namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/canceltimingsale 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductCategoryCancelTimingSaleRequest : WechatApiRequest, IInferable<ChannelsECProductCategoryCancelTimingSaleRequest, ChannelsECProductCategoryCancelTimingSaleResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
        public long ProductId { get; set; }
    }
}
