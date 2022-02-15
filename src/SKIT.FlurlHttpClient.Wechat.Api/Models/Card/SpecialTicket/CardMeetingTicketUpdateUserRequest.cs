namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/meetingticket/updateuser 接口的请求。</para>
    /// </summary>
    public class CardMeetingTicketUpdateUserRequest : WechatApiRequest, IMapResponse<CardMeetingTicketUpdateUserRequest, CardMeetingTicketUpdateUserResponse>
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置原卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string CardCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会议开场时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long? BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置会议结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置会场区域。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zone")]
        [System.Text.Json.Serialization.JsonPropertyName("zone")]
        public string? Zone { get; set; }

        /// <summary>
        /// 获取或设置会场入口。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entrance")]
        [System.Text.Json.Serialization.JsonPropertyName("entrance")]
        public string? Entrance { get; set; }

        /// <summary>
        /// 获取或设置座位号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seat_number")]
        [System.Text.Json.Serialization.JsonPropertyName("seat_number")]
        public string? SeatNumber { get; set; }
    }
}
