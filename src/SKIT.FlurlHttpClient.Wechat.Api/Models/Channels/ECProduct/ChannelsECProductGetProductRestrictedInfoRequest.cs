namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/getproductrestrictedinfo 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductGetProductRestrictedInfoRequest : WechatApiRequest, IInferable<ChannelsECProductGetProductRestrictedInfoRequest, ChannelsECProductGetProductRestrictedInfoResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
        public List<long>? ProductIdList { get; set; }
    }
}
