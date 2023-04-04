namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/queryexchagerate 接口的响应。</para>
    /// </summary>
    public class GetPayExchangeRateResponse : WechatTenpaySignableResponse
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
        /// 获取或设置币种。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee_type")]
        [System.Text.Json.Serialization.JsonPropertyName("fee_type")]
        public string FeeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置汇率日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rate_time")]
        [System.Text.Json.Serialization.JsonPropertyName("rate_time")]
        public string DateString { get; set; } = default!;

        /// <summary>
        /// 获取或设置汇率（格式：外币兑换人民币的比例乘以 10 的 8 次方）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rate")]
        [System.Text.Json.Serialization.JsonPropertyName("rate")]
        public double? ExchangeRate { get; set; } = default!;
    }
}
