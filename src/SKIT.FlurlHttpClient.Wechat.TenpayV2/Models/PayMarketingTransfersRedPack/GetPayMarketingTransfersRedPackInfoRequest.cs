namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /mmpaymkttransfers/gethbinfo 接口的请求。</para>
    /// </summary>
    public class GetPayMarketingTransfersRedPackInfoRequest : WechatTenpaySignableRequest
    {
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
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_billno")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_billno")]
        public string MerchantBillId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单类型。
        /// <para>默认值：MCHT</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_type")]
        public string BillType { get; set; } = "MCHT";
    }
}
