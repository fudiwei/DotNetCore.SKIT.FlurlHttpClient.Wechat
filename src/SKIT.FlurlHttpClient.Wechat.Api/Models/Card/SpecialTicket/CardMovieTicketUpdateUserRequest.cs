using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/movieticket/updateuser 接口的请求。</para>
    /// </summary>
    public class CardMovieTicketUpdateUserRequest : WechatApiRequest, IMapResponse<CardMovieTicketUpdateUserRequest, CardMovieTicketUpdateUserResponse>
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
        /// 获取或设置电影票类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket_class")]
        [System.Text.Json.Serialization.JsonPropertyName("ticket_class")]
        public string? TicketClass { get; set; }

        /// <summary>
        /// 获取或设置影厅信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("screening_room")]
        [System.Text.Json.Serialization.JsonPropertyName("screening_room")]
        public string? ScreeningRoom { get; set; }

        /// <summary>
        /// 获取或设置电影放映时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("show_time")]
        [System.Text.Json.Serialization.JsonPropertyName("show_time")]
        public long? ShowTimestamp { get; set; }

        /// <summary>
        /// 获取或设置电影放映时长（单位：分钟）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duration")]
        [System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 获取或设置座位号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seat_number")]
        [System.Text.Json.Serialization.JsonPropertyName("seat_number")]
        public IList<string>? SeatNumberList { get; set; }
    }
}
