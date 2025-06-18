namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_live_notice_reservation_info 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetLiveNoticeReservationInfoRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetLiveNoticeReservationInfoRequest, ChannelsECPromoterGetLiveNoticeReservationInfoResponse>
    {
        /// <summary>
        /// 获取或设置推客 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
        public string SharerAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预约 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_notice_id")]
        [System.Text.Json.Serialization.JsonPropertyName("live_notice_id")]
        public string NoticeId { get; set; } = string.Empty;
    }
}
