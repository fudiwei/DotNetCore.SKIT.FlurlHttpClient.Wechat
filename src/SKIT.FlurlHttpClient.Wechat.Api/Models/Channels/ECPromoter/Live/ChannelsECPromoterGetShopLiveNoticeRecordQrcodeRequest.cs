namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_shop_live_notice_record_qr_code 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetShopLiveNoticeRecordQrcodeRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetShopLiveNoticeRecordQrcodeRequest, ChannelsECPromoterGetShopLiveNoticeRecordQrcodeResponse>
    {
        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string ShopId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置推客 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
        public string? SharerAppId { get; set; }

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

        /// <summary>
        /// 获取或设置预约 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notice_id")]
        [System.Text.Json.Serialization.JsonPropertyName("notice_id")]
        public string NoticeId { get; set; } = string.Empty;
    }
}
