namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_product_promotion_link_info 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetProductPromotionLinkInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商品推广短链。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("short_link")]
        [System.Text.Json.Serialization.JsonPropertyName("short_link")]
        public string ShortLink { get; set; } = default!;
    }
}
