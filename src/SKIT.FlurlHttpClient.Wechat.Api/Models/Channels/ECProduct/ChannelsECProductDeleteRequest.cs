namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/delete 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductDeleteRequest : WechatApiRequest, IInferable<ChannelsECProductDeleteRequest, ChannelsECProductDeleteResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }
    }
}
