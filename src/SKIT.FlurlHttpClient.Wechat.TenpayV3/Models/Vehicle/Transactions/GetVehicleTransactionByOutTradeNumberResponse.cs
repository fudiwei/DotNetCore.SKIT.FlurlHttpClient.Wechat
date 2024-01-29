using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /vehicle/transactions/out-trade-no/{out_trade_no} 接口的响应。</para>
    /// </summary>
    public class GetVehicleTransactionByOutTradeNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Payer
            {
                /// <summary>
                /// 获取或设置用户的唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户在子商户下唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
                public string? SubOpenId { get; set; }
            }

            public class Amount
            {
                /// <summary>
                /// 获取或设置总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int Total { get; set; }

                /// <summary>
                /// 获取或设置币种。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string? Currency { get; set; }

                /// <summary>
                /// 获取或设置用户支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_total")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_total")]
                public int? PayerTotal { get; set; }

                /// <summary>
                /// 获取或设置折扣金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_total")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_total")]
                public int? DiscountTotal { get; set; }
            }

            public class Parking
            {
                /// <summary>
                /// 获取或设置停车入场 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parking_id")]
                [System.Text.Json.Serialization.JsonPropertyName("parking_id")]
                public string ParkingId { get; set; } = default!;

                /// <summary>
                /// 获取或设置车牌号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plate_number")]
                [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
                public string PlateNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置车牌颜色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plate_color")]
                [System.Text.Json.Serialization.JsonPropertyName("plate_color")]
                public string PlateColor { get; set; } = default!;

                /// <summary>
                /// 获取或设置入场时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset StartTime { get; set; }

                /// <summary>
                /// 获取或设置出场时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset EndTime { get; set; }

                /// <summary>
                /// 获取或设置停车场名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parking_name")]
                [System.Text.Json.Serialization.JsonPropertyName("parking_name")]
                public string ParkingName { get; set; } = default!;

                /// <summary>
                /// 获取或设置计费时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("charging_duration")]
                [System.Text.Json.Serialization.JsonPropertyName("charging_duration")]
                public int ChargingDuration { get; set; }

                /// <summary>
                /// 获取或设置停车场设备 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_id")]
                [System.Text.Json.Serialization.JsonPropertyName("device_id")]
                public string? DeviceId { get; set; }
            }

            public class Promotion
            {
                /// <summary>
                /// 获取或设置券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                public string CouponId { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置优惠范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scope")]
                [System.Text.Json.Serialization.JsonPropertyName("scope")]
                public string? Scope { get; set; }

                /// <summary>
                /// 获取或设置优惠类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// 获取或设置优惠券面额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_id")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
                public string? StockId { get; set; }

                /// <summary>
                /// 获取或设置微信出资（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wechatpay_contribute")]
                [System.Text.Json.Serialization.JsonPropertyName("wechatpay_contribute")]
                public int? WechatpayContribute { get; set; }

                /// <summary>
                /// 获取或设置商户出资（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_contribute")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_contribute")]
                public int? MerchantContribute { get; set; }

                /// <summary>
                /// 获取或设置其他出资（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("other_contribute")]
                [System.Text.Json.Serialization.JsonPropertyName("other_contribute")]
                public int? OtherContribute { get; set; }

                /// <summary>
                /// 获取或设置优惠币种。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string? Currency { get; set; }
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Internal.YesOrNoBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("user_repaid")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Internal.YesOrNoBooleanConverter))]
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置订单创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
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
