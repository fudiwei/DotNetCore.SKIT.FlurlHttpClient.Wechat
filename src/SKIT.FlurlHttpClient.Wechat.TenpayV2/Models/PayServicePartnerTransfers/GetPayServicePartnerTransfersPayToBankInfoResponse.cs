using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /mmpaysptrans/query_bank 接口的响应。</para>
    /// </summary>
    public class GetPayServicePartnerTransfersPayToBankInfoResponse : WechatTenpaySignableResponse
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
        /// <i>（冗余字段，请忽略）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("partner_trade_no")]
        public string PartnerTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置微信付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_no")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_no")]
        public string PaymentNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款方银行卡号的 MD5 哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_no_md5")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_no_md5")]
        public string BankNumberMD5Value { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款方用户名的 MD5 哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("true_name_md5")]
        [System.Text.Json.Serialization.JsonPropertyName("true_name_md5")]
        public string UserNameMD5Value { get; set; } = default!;

        /// <summary>
        /// 获取或设置手续费金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cmms_amt")]
        [System.Text.Json.Serialization.JsonPropertyName("cmms_amt")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int CMMSAmount { get; set; }

        /// <summary>
        /// 获取或设置转账状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置下单时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置转账成功时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_succ_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pay_succ_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? FailReason { get; set; }
    }
}
