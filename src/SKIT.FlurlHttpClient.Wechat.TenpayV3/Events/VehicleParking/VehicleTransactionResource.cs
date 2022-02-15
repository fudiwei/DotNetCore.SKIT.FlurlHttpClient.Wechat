using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 TRANSACTION.SUCCESS（仅限微信支付分停车服务）通知的数据。</para>
    /// <para>表示 TRANSACTION.FAIL（仅限微信支付分停车服务）通知的数据。</para>
    /// <para>表示 TRANSACTION.PAY_BACK（仅限微信支付分停车服务）通知的数据。</para>
    /// </summary>
    public class VehicleTransactionResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        public static class Types
        {
            public class Payer : Models.GetVehicleTransactionByOutTradeNumberResponse.Types.Payer
            {
            }

            public class Amount : Models.GetVehicleTransactionByOutTradeNumberResponse.Types.Amount
            {
            }

            public class Parking : Models.GetVehicleTransactionByOutTradeNumberResponse.Types.Parking
            {
            }

            public class Promotion : Models.GetVehicleTransactionByOutTradeNumberResponse.Types.Promotion
            {
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置服务描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

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
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置交易状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_state")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_state")]
        public string TradeState { get; set; } = default!;

        /// <summary>
        /// 获取或设置交易状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_state_description")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_state_description")]
        public string TradeStateDescription { get; set; } = default!;

        /// <summary>
        /// 获取或设置付款银行类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
        public string? BankType { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置用户是否还款。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_repaid")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.YesOrNoNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("user_repaid")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.YesOrNoNullableBooleanConverter))]
        public bool? IsUserRepaid { get; set; }

        /// <summary>
        /// 获取或设置交易场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_scene")]
        public string TradeScene { get; set; } = default!;

        /// <summary>
        /// 获取或设置支付完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置订单创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer? Payer { get; set; }

        /// <summary>
        /// 获取或设置金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount Amount { get; set; } = default!;

        /// <summary>
        /// 获取或设置停车信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parking_info")]
        [System.Text.Json.Serialization.JsonPropertyName("parking_info")]
        public Types.Parking? Parking { get; set; }

        /// <summary>
        /// 获取或设置优惠信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
        public Types.Promotion[]? PromotionList { get; set; }
    }
}
