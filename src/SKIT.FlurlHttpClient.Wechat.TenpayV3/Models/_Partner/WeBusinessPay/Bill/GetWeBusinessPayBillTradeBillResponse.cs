namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /webizpay/bill/trade-bill 接口的响应。</para>
    /// </summary>
    public class GetWeBusinessPayBillTradeBillResponse : WechatTenpayResponse
    {
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
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置账单日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public string BillDateString { get; set; } = default!;

        /// <summary>
        /// 获取或设置账单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string BillType { get; set; } = default!;

        /// <summary>
        /// 获取或设置哈希类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hash_type")]
        [System.Text.Json.Serialization.JsonPropertyName("hash_type")]
        public string HashType { get; set; } = default!;

        /// <summary>
        /// 获取或设置哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hash_value")]
        [System.Text.Json.Serialization.JsonPropertyName("hash_value")]
        public string HashValue { get; set; } = default!;

        /// <summary>
        /// 获取或设置账单下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_url")]
        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; } = default!;
    }
}
