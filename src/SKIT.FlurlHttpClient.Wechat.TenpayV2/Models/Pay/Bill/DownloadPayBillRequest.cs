namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/downloadbill 接口的请求。</para>
    /// </summary>
    public class DownloadPayBillRequest : WechatTenpaySignableRequest
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
        /// 获取或设置账单日期（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_date")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_date")]
        public string BillDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置账单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_type")]
        public string? BillType { get; set; }

        /// <summary>
        /// 获取或设置压缩方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tar_type")]
        [System.Text.Json.Serialization.JsonPropertyName("tar_type")]
        public string? TarType { get; set; }
    }
}
