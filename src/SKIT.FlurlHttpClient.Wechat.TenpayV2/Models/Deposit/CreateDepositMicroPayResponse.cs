using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /deposit/micropay 接口的响应。</para>
    /// </summary>
    public class CreateDepositMicroPayResponse : WechatTenpaySignableResponse
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
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置终端设备号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_info")]
        [System.Text.Json.Serialization.JsonPropertyName("device_info")]
        public string? DeviceInfo { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户是否订阅该公众号标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_subscribe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Internal.YesOrNoBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_subscribe")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Internal.YesOrNoBooleanConverter))]
        public bool IsSubscribed { get; set; }

        /// <summary>
        /// 获取或设置用户在子商户下的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

        /// <summary>
        /// 获取或设置用户是否订阅子商户公众号标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_is_subscribe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Internal.YesOrNoBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("sub_is_subscribe")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Internal.YesOrNoBooleanConverter))]
        public bool? IsSubSubscribed { get; set; }

        /// <summary>
        /// 获取或设置交易类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
        public string TradeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置付款银行。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
        public string BankType { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("total_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalFee { get; set; }

        /// <summary>
        /// 获取或设置货币类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee_type")]
        [System.Text.Json.Serialization.JsonPropertyName("fee_type")]
        public string? FeeType { get; set; }

        /// <summary>
        /// 获取或设置应结订单金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_total_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_total_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? SettlementFee { get; set; }

        /// <summary>
        /// 获取或设置代金券金额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? CouponFee { get; set; }

        /// <summary>
        /// 获取或设置现金支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cash_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("cash_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? CashFee { get; set; }

        /// <summary>
        /// 获取或设置现金支付货币类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cash_fee_type")]
        [System.Text.Json.Serialization.JsonPropertyName("cash_fee_type")]
        public string? CashFeeType { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置支付完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_end")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.DigitalDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_end")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.DigitalDateTimeOffsetConverter))]
        public DateTimeOffset? EndTime { get; set; }

        /// <inheritdoc/>
        /// <remarks>
        /// 针对押金支付接口，当押金支付不需要等待用户输入密码时，微信会直接冻结资金并返回表示交易成功的响应体，
        /// 此时错误代码 err_code 节点的值为 "SUCCESS"，应当被视为成功。
        /// </remarks>
        public override bool IsSuccessful()
        {
            bool ret1 = GetRawStatus() == 200 && "SUCCESS".Equals(ReturnCode);
            bool ret2 = string.IsNullOrEmpty(ErrorCode) || "0".Equals(ErrorCode) || "SUCCESS".Equals(ErrorCode);
            bool ret3 = string.IsNullOrEmpty(ResultCode) || "SUCCESS".Equals(ResultCode);
            return ret1 && ret2 && ret3;
        }
    }
}
