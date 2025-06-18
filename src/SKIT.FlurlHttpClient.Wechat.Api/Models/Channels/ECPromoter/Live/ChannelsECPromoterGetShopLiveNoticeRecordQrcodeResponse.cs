namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_shop_live_notice_record_qr_code 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetShopLiveNoticeRecordQrcodeResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_url")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_url")]
        public string QrcodeUrl { get; set; } = default!;
    }
}
