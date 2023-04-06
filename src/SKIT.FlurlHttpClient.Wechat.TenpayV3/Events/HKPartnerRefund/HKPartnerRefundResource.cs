namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 REFUND.SUCCESS （仅限服务商 For HK）通知的数据。</para>
    /// <para>表示 REFUND.ABNORMAL （仅限服务商 For HK）通知的数据。</para>
    /// <para>表示 REFUND.CLOSED （仅限服务商 For HK）通知的数据。</para>
    /// </summary>
    public class HKPartnerRefundResource : HKRefundResource, WechatTenpayEvent.Types.IDecryptedResource
    {
        public static new class Types
        {
            public class Amount : Models.GetHKPartnerRefundByOutRefundNumberResponse.Types.Amount
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
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public new Types.Amount Amount { get; set; } = default!;
    }
}
