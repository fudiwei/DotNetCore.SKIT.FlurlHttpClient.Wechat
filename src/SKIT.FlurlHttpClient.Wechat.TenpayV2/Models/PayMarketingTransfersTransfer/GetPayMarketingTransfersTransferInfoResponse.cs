using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /mmpaymkttransfers/gettransferinfo 接口的响应。</para>
    /// </summary>
    public class GetPayMarketingTransfersTransferInfoResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("partner_trade_no")]
        public string PartnerTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail_id")]
        [System.Text.Json.Serialization.JsonPropertyName("detail_id")]
        public string PaymentNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_amount")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置终端设备号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款用户姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_name")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_name")]
        public string? UserName { get; set; }

        /// <summary>
        /// 获取或设置转账状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置转账时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
        public DateTimeOffset TransferTime { get; set; }

        /// <summary>
        /// 获取或设置付款成功时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("payment_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? FailReason { get; set; }
    }
}
