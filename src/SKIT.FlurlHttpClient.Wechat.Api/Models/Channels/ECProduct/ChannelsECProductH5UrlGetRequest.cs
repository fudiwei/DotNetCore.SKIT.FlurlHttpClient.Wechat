namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/h5url/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductH5UrlGetRequest : WechatApiRequest, IInferable<ChannelsECProductH5UrlGetRequest, ChannelsECProductH5UrlGetResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }
    }
}
