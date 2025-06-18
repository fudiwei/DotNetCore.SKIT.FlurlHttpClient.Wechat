namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /mmpaymkttransfers/sendworkwxredpack 接口的响应。</para>
    /// </summary>
    public class SendPayMarketingTransfersWeWorkRedPackResponse : WechatTenpaySignableResponse
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
        [Newtonsoft.Json.JsonProperty("wxappid")]
        [System.Text.Json.Serialization.JsonPropertyName("wxappid")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string AppId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_billno")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_billno")]
        public string MerchantBillNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置接受红包的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("re_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("re_openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置红包金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置微信红包订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_listid")]
        [System.Text.Json.Serialization.JsonPropertyName("send_listid")]
        public string PaymentNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置红包发送者名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender_name")]
        [System.Text.Json.Serialization.JsonPropertyName("sender_name")]
        public string? SenderName { get; set; }

        /// <summary>
        /// 获取或设置红包发送者头像 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender_header_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sender_header_media_id")]
        public string? SenderHeadImageMediaId { get; set; }
    }
}
