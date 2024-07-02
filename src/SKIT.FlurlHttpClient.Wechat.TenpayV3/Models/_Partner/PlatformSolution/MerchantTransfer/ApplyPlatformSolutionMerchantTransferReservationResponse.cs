using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/mch-transfer/reservation/apply 接口的响应。</para>
    /// </summary>
    public class ApplyPlatformSolutionMerchantTransferReservationResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户预约单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_reservation_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_reservation_no")]
        public string OutReservationNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信预约单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reservation_id")]
        [System.Text.Json.Serialization.JsonPropertyName("reservation_id")]
        public string ReservationId { get; set; } = default!;

        /// <summary>
        /// 获取或设置预约记录状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置预约受理时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("accept_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset AcceptTime { get; set; }

        /// <summary>
        /// 获取或设置跳转预约页面的信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_info")]
        [System.Text.Json.Serialization.JsonPropertyName("package_info")]
        public string? PackageInfo { get; set; }
    }
}
