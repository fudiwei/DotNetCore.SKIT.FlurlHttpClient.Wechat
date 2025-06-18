namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_shop_live_notice_record_list 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetShopLiveNoticeRecordListRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetShopLiveNoticeRecordListRequest, ChannelsECPromoterGetShopLiveNoticeRecordListResponse>
    {
        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string ShopId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置关联账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoter_id")]
        [System.Text.Json.Serialization.JsonPropertyName("promoter_id")]
        public string PromoterId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置关联账号类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoter_type")]
        [System.Text.Json.Serialization.JsonPropertyName("promoter_type")]
        public int PromoterType { get; set; }
    }
}
