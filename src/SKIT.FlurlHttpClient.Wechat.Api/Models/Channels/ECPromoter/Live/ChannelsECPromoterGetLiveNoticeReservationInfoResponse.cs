namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_live_notice_reservation_info 接口的响应。</para>
    /// </summary>
    public class ChannelsECPromoterGetLiveNoticeReservationInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置预约人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
