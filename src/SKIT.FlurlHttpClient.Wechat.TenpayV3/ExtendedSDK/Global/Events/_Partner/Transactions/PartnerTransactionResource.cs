namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Events
{
    /// <summary>
    /// <para>表示 TRANSACTION.SUCCESS （仅限服务商）通知的数据。</para>
    /// </summary>
    public class PartnerTransactionResource : TransactionResource, WechatTenpayGlobalEvent.Types.IDecryptedResource
    {
        public static new class Types
        {
            public class Payer : Models.GetPartnerTransactionByOutTradeNumberResponse.Types.Payer
            {
            }

            public class Amount : Models.GetPartnerTransactionByOutTradeNumberResponse.Types.Amount
            {
            }

            public class Promotion : Models.GetPartnerTransactionByOutTradeNumberResponse.Types.Promotion
            {
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public override string MerchantId { get; set; } = default!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public override string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public new Types.Payer? Payer { get; set; }

        /// <summary>
        /// 获取或设置金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public new Types.Amount Amount { get; set; } = default!;

        /// <summary>
        /// 获取或设置优惠信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
        public new Types.Promotion[]? PromotionList { get; set; }
    }
}
