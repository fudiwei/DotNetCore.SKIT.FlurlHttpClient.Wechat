using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /taxi-invoice/cards/upload-file 接口的请求。</para>
    /// </summary>
    public class UploadTaxiInvoiceCardFileRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置文件内容哈希算法。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("digest_algorithm")]
        [System.Text.Json.Serialization.JsonPropertyName("digest_algorithm")]
        public string FileHashAlgorithm { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件内容哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("digest")]
        [System.Text.Json.Serialization.JsonPropertyName("digest")]
        public string FileHashValue { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公司商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("company_mchid")]
        public string CompanyMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_id")]
        [System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public int RegionId { get; set; }
    }
}
