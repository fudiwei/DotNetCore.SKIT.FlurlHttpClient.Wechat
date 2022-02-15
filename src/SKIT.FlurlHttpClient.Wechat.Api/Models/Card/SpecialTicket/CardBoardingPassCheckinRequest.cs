using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/boardingpass/checkin 接口的请求。</para>
    /// </summary>
    public class CardBoardingPassCheckinRequest : WechatApiRequest, IMapResponse<CardBoardingPassCheckinRequest, CardBoardingPassCheckinResponse>
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
        /// 获取或设置电子客票号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("etkt_bnr")]
        [System.Text.Json.Serialization.JsonPropertyName("etkt_bnr")]
        public string? TicketNumber { get; set; }

        /// <summary>
        /// 获取或设置舱等。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("class")]
        [System.Text.Json.Serialization.JsonPropertyName("class")]
        public string? TicketClass { get; set; }

        /// <summary>
        /// 获取或设置乘客姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("passenger_name")]
        [System.Text.Json.Serialization.JsonPropertyName("passenger_name")]
        public string? PassengerName { get; set; }

        /// <summary>
        /// 获取或设置座位号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seat")]
        [System.Text.Json.Serialization.JsonPropertyName("seat")]
        public string? SeatNumber { get; set; }

        /// <summary>
        /// 获取或设置二维码数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_data")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_data")]
        public string? QrcodeData { get; set; }

        /// <summary>
        /// 获取或设置是否取消值机。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_cancel")]
        [System.Text.Json.Serialization.JsonPropertyName("is_cancel")]
        public bool? IsCancel { get; set; }
    }
}
