namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/platformkf/operatemchticket 接口的请求。</para>
    /// </summary>
    public class ChannelsECPlatformKfOperateMerchantTicketRequest : WechatApiRequest, IInferable<ChannelsECPlatformKfOperateMerchantTicketRequest, ChannelsECPlatformKfOperateMerchantTicketResponse>
    {
        /// <summary>
        /// 获取或设置工单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ticket_id")]
        public string? TicketId { get; set; }

        /// <summary>
        /// 获取或设置回复选项 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reply_option")]
        [System.Text.Json.Serialization.JsonPropertyName("reply_option")]
        public int? ReplyOptionId { get; set; }

        /// <summary>
        /// 获取或设置补充说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置与用户协商时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confer_time")]
        [System.Text.Json.Serialization.JsonPropertyName("confer_time")]
        public long? ConferTimestamp { get; set; }
    }
}
