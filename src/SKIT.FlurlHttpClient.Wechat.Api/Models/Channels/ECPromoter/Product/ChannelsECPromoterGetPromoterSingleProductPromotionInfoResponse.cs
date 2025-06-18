namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_promoter_single_product_promotion_info 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetPromoterSingleProductPromotionInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商品小程序跳转小店场景添加商品时传递的推广信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_promotion_link")]
        [System.Text.Json.Serialization.JsonPropertyName("product_promotion_link")]
        public string ProductPromotionLink { get; set; } = default!;
    }
}
