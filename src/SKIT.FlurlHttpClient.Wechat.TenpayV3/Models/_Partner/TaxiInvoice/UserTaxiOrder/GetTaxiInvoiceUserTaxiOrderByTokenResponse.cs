using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /taxi-invoice/user-taxi-order/find-by-token 接口的响应。</para>
    /// </summary>
    public class GetTaxiInvoiceUserTaxiOrderByTokenResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置车牌号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_number")]
        [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
        public string PlateNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置司机资格证号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("driver_license")]
        [System.Text.Json.Serialization.JsonPropertyName("driver_license")]
        public string DriverLicenseNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置上车时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("up_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("up_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset UpTime { get; set; }

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_id")]
        [System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public int RegionId { get; set; }

        /// <summary>
        /// 获取或设置乘客行程单来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source")]
        [System.Text.Json.Serialization.JsonPropertyName("source")]
        public string Source { get; set; } = default!;

        /// <summary>
        /// 获取或设置付款时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? PayTime { get; set; }

        /// <summary>
        /// 获取或设置付款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
        public int? PayAmount { get; set; }
    }
}
