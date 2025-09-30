using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /mmpaymkttransfers/queryworkwxredpack 接口的响应。</para>
    /// </summary>
    public class GetPayMarketingTransfersWeWorkRedPackResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string MerchantId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string AppId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_billno")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_billno")]
        public string MerchantBillNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置红包单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail_id")]
        [System.Text.Json.Serialization.JsonPropertyName("detail_id")]
        public string DetailId { get; set; } = default!;

        /// <summary>
        /// 获取或设置红包状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置发放类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_type")]
        [System.Text.Json.Serialization.JsonPropertyName("send_type")]
        public string SendType { get; set; } = default!;

        /// <summary>
        /// 获取或设置红包金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置红包祝福语。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wishing")]
        [System.Text.Json.Serialization.JsonPropertyName("wishing")]
        public string? Wishing { get; set; }

        /// <summary>
        /// 获取或设置活动名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("act_name")]
        [System.Text.Json.Serialization.JsonPropertyName("act_name")]
        public string? ActivityName { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置红包发送时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("send_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
        public DateTimeOffset SendTime { get; set; }

        /// <summary>
        /// 获取或设置红包退款时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("refund_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
        public DateTimeOffset? RefundTime { get; set; }

        /// <summary>
        /// 获取或设置红包退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int RefundAmount { get; set; }

        /// <summary>
        /// 获取或设置失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// 获取或设置红包发送者名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender_name")]
        [System.Text.Json.Serialization.JsonPropertyName("sender_name")]
        public string? SenderName { get; set; }

        /// <summary>
        /// 获取或设置红包发送者头像 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender_header_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sender_header_media_id")]
        public string? SenderHeadImageMediaId { get; set; }

        /// <summary>
        /// 获取或设置领取红包的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置领取金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置领取时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rcv_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("rcv_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
        public DateTimeOffset ReceiveTime { get; set; }
    }
}
