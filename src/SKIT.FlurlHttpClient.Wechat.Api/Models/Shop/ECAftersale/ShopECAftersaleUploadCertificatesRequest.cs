using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ecaftersale/upload_certificates 接口的请求。</para>
    /// </summary>
    public class ShopECAftersaleUploadCertificatesRequest : WechatApiRequest, IInferable<ShopECAftersaleUploadCertificatesRequest, ShopECAftersaleUploadCertificatesResponse>
    {
        /// <summary>
        /// 获取或设置售后单号。与字段 <see cref="OutAftersaleOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
        public long? AftersaleOrderId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义售后单号。与字段 <see cref="AftersaleOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_aftersale_id")]
        public string? OutAftersaleOrderId { get; set; }

        /// <summary>
        /// 获取或设置协商文本内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_desc")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置凭证图片 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificates")]
        [System.Text.Json.Serialization.JsonPropertyName("certificates")]
        public IList<string> CertificateUrlList { get; set; } = new List<string>();
    }
}
