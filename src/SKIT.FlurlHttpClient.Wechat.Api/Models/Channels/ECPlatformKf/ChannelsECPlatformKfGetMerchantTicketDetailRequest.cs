namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/platformkf/getmchticketdetail 接口的请求。</para>
    /// </summary>
    public class ChannelsECPlatformKfGetMerchantTicketDetailRequest : WechatApiRequest, IInferable<ChannelsECPlatformKfGetMerchantTicketDetailRequest, ChannelsECPlatformKfGetMerchantTicketDetailResponse>
    {
        /// <summary>
        /// 获取或设置工单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ticket_id")]
        public string? TicketId { get; set; }
    }
}
