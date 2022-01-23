using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /mmpaymkttransfers/gethbinfo 接口的响应。</para>
    /// </summary>
    public class GetPayMarketingTransfersRedPackInfoResponse : WechatTenpaySignableResponse
    {
        public static class Types
        {
            public class ReceiverList
            {
                /// <summary>
                /// 获取或设置红包领取列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hbinfo")]
                [System.Text.Json.Serialization.JsonPropertyName("hbinfo")]
                public ReceiverItem[] Items { get; set; } = default!;
            }

            public class ReceiverItem
            {
                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置领取时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rcv_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("rcv_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset ReceiveTime { get; set; }
            }
        }

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
        /// 获取或设置商户定单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_billno")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_billno")]
        public string PartnerTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信红包订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail_id")]
        [System.Text.Json.Serialization.JsonPropertyName("detail_id")]
        public string PaymentNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置转账状态。
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
        /// 获取或设置红包类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hb_type")]
        [System.Text.Json.Serialization.JsonPropertyName("hb_type")]
        public string RedPackType { get; set; } = default!;

        /// <summary>
        /// 获取或设置红包金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置红包数量。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalCount { get; set; } = 1;

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("send_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
        public DateTimeOffset SendTime { get; set; }

        /// <summary>
        /// 获取或设置红包退款时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("refund_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
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
        /// 获取或设置红包领取列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hblist")]
        [System.Text.Json.Serialization.JsonPropertyName("hblist")]
        public Types.ReceiverList ReceiverList { get; set; } = default!;
    }
}
