namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/downloadfundflow 接口的请求。</para>
    /// </summary>
    public class DownloadPayFundFlowRequest : WechatTenpaySignableRequest
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
        /// 获取或设置账单日期（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_date")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_date")]
        public string BillDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置资金账户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
        public string? AccountType { get; set; }

        /// <summary>
        /// 获取或设置压缩方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tar_type")]
        [System.Text.Json.Serialization.JsonPropertyName("tar_type")]
        public string? TarType { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// <para>默认值：<see cref="Constants.SignTypes.HMAC_SHA256"/></para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_type")]
#pragma warning disable CS8765
        public override string SignType { get; set; } = Constants.SignTypes.HMAC_SHA256;
#pragma warning restore CS8765
    }
}
