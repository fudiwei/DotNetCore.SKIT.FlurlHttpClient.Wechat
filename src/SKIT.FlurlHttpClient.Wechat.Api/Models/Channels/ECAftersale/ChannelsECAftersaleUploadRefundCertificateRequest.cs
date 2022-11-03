using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/uploadrefundcertificate 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleUploadRefundCertificateRequest : WechatApiRequest, IInferable<ChannelsECAftersaleUploadRefundCertificateRequest, ChannelsECAftersaleUploadRefundCertificateResponse>
    {
        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
        public long AftersaleOrderId { get; set; }

        /// <summary>
        /// 获取或设置退款凭证 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_certificates")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_certificates")]
        public IList<string> RefundCertificateMediaIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string Description { get; set; } = string.Empty;
    }
}
