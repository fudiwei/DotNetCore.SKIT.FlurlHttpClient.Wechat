using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/card/invoice/reimburse/updatestatusbatch 接口的请求。</para>
    /// </summary>
    public class CgibinCardInvoiceReimburseUpdateStatusBatchRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class InvoiceCard
            {
                /// <summary>
                /// 获取或设置发票卡券模板编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_id")]
                [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                public string CardId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置经过加密的发票卡券 Code。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_code")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_code")]
                public string EncryptedCardCode { get; set; } = string.Empty;
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
