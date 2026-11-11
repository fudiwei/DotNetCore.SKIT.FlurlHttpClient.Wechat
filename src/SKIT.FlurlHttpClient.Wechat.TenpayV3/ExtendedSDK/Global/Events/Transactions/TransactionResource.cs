namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Events
{
    /// <summary>
    /// <para>表示 TRANSACTION.SUCCESS （仅限直连商户）回调通知事件的数据。</para>
    /// </summary>
    public class TransactionResource : WechatTenpayGlobalEvent.Meta.IDecryptedResource
    {
        public static class Types
        {
            public class Payer : Models.GetTransactionByOutTradeNumberResponse.Types.Payer
            {
            }

            public class Amount : Models.GetTransactionByOutTradeNumberResponse.Types.__zz__Amount
            {
                public static class Types
                {
                    public class ExchangeRate : Models.GetTransactionByOutTradeNumberResponse.Types.Amount.Types.ExchangeRate
                    {
                    }
                }

                /// <summary>
                /// 获取或设置汇率信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exchange_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("exchange_rate")]
                public Types.ExchangeRate? ExchangeRate { get; set; }
            }

            public class Promotion : Models.GetTransactionByOutTradeNumberResponse.Types.__zz__Promotion
            {
                public static class Types
                {
                    public class GoodsDetail : Models.GetTransactionByOutTradeNumberResponse.Types.Promotion.Types.GoodsDetail
                    {
                    }
                }

                /// <summary>
                /// 获取或设置单品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                public List<Types.GoodsDetail>? GoodsList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置交易类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
        public string? TradeType { get; set; }

        /// <summary>
        /// 获取或设置交易状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_state")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_state")]
        public string? TradeState { get; set; }

        /// <summary>
        /// 获取或设置交易状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_state_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_state_desc")]
        public string? TradeStateDescription { get; set; }

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
        /// 获取或设置支付完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset SuccessTime { get; set; }

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
        public Types.Amount? Amount { get; set; }

        /// <summary>
        /// 获取或设置优惠信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
        public List<Types.Promotion>? PromotionList { get; set; }
    }
}
