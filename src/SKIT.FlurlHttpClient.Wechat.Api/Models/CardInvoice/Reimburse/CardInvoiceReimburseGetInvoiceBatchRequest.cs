using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/reimburse/getinvoicebatch 接口的请求。</para>
    /// </summary>
    public class CardInvoiceReimburseGetInvoiceBatchRequest : WechatApiRequest
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
        /// 获取或设置发票卡券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_list")]
        [System.Text.Json.Serialization.JsonPropertyName("item_list")]
        public IList<Types.InvoiceCard> InvoiceCardList { get; set; } = new List<Types.InvoiceCard>();
    }
}
