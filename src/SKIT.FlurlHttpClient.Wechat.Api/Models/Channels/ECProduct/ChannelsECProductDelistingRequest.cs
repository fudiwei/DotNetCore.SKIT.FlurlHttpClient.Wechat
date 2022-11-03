namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/delisting 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductDelistingRequest : WechatApiRequest, IInferable<ChannelsECProductDelistingRequest, ChannelsECProductDelistingResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }
    }
}
