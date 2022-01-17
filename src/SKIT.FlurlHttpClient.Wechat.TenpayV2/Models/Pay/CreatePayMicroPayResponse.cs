using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/micropay 接口的响应。</para>
    /// </summary>
    public class CreatePayMicroPayResponse : WechatTenpaySignableResponse
    {
        public static class Types
        {
            public class Promotion
            {
                public static class Types
                {
                    public class GoodsDetail
                    {
                        /// <summary>
                        /// 获取或设置商品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_id")]
                        public string GoodsId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                        public int Quantity { get; set; }

                        /// <summary>
                        /// 获取或设置商品单价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public int Price { get; set; }

                        /// <summary>
                        /// 获取或设置商品优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
                        public int DiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置商品备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_remark")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_remark")]
                        public string? GoodsRemark { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置券或者立减优惠 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_id")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_id")]
                public string PromotionId { get; set; } = default!;

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
                [Newtonsoft.Json.JsonProperty("activity_id")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                public string? ActivityId { get; set; }

                /// <summary>
                /// 获取或设置微信出资（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxpay_contribute")]
                [System.Text.Json.Serialization.JsonPropertyName("wxpay_contribute")]
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
                /// 获取或设置单品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                public Types.GoodsDetail[]? GoodsList { get; set; }
            }
        }

        internal static class Converters
        {
            internal class ResponsePropertyPromotionListNewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter<Types.Promotion[]?>
            {
                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override Types.Promotion[]? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, Types.Promotion[]? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
                    {
                        return existingValue;
                    }
                    else if (reader.TokenType == Newtonsoft.Json.JsonToken.String)
                    {
                        string? value = serializer.Deserialize<string>(reader);
                        if (value == null)
                            return existingValue;

                        return Newtonsoft.Json.JsonConvert.DeserializeObject<Types.Promotion[]>(value);
                    }

                    throw new Newtonsoft.Json.JsonReaderException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, Types.Promotion[]? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (value != null)
                        writer.WriteValue(Newtonsoft.Json.JsonConvert.SerializeObject(value));
                    else
                        writer.WriteNull();
                }
            }

            internal class ResponsePropertyPromotionListSystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<Types.Promotion[]?>
            {
                public override Types.Promotion[]? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    if (reader.TokenType == System.Text.Json.JsonTokenType.Null)
                    {
                        return null;
                    }
                    else if (reader.TokenType == System.Text.Json.JsonTokenType.String)
                    {
                        string? value = reader.GetString();
                        if (value == null)
                            return null;

                        return System.Text.Json.JsonSerializer.Deserialize<Types.Promotion[]>(value);
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, Types.Promotion[]? value, System.Text.Json.JsonSerializerOptions options)
                {
                    if (value != null)
                        writer.WriteStringValue(System.Text.Json.JsonSerializer.Serialize(value));
                    else
                        writer.WriteNullValue();
                }
            }
        }

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
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户是否订阅该公众号标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_subscribe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.YesOrNoBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_subscribe")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.YesOrNoBooleanConverter))]
        public bool IsSubscribed { get; set; }

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
        public int? SettlementFee { get; set; }

        /// <summary>
        /// 获取或设置代金券金额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_fee")]
        public int? FouponFee { get; set; }

        /// <summary>
        /// 获取或设置现金支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cash_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("cash_fee")]
        public int CashFee { get; set; }

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_end")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// 获取或设置优惠信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_detail")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyPromotionListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyPromotionListSystemTextJsonConverter))]
        public Types.Promotion[]? PromotionList { get; set; }
    }
}
