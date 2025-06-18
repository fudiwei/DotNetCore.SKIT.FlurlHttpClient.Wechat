using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/reimburse/updatestatusbatch 接口的请求。</para>
    /// </summary>
    public class CardInvoiceReimburseUpdateStatusBatchRequest : WechatApiRequest, IInferable<CardInvoiceReimburseUpdateStatusBatchRequest, CardInvoiceReimburseUpdateStatusBatchResponse>
    {
        public static class Types
        {
            public class InvoiceCard : CardInvoiceReimburseGetInvoiceBatchRequest.Types.InvoiceCard
            {
            }
        }

        /// <summary>
        /// 获取或设置获得发票的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发票报销状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reimburse_status")]
        [System.Text.Json.Serialization.JsonPropertyName("reimburse_status")]
        public string ReimburseStatus { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发票卡券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invoice_list")]
        public IList<Types.InvoiceCard> InvoiceCardList { get; set; } = new List<Types.InvoiceCard>();
    }
}
