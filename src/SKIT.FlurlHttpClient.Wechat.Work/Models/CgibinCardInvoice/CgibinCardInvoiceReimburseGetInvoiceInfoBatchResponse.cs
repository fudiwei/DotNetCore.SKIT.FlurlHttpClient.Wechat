using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/card/invoice/reimburse/getinvoiceinfobatch 接口的响应。</para>
    /// </summary>
    public class CgibinCardInvoiceReimburseGetInvoiceInfoBatchResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class InvoiceCard
            {
                public static class Types
                {
                    public class Invoice : CgibinCardInvoiceReimburseGetInvoiceInfoResponse.Types.Invoice
                    {
                    }
                }

                /// <summary>
                /// 获取或设置发票卡券模板编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_id")]
                [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                public string CardId { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票的有效期起始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                public long BeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置发票的有效期截止时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置发票卡券模板编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_card_status")]
                [System.Text.Json.Serialization.JsonPropertyName("user_card_status")]
                public string CardStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置获得发票的用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置开票类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置开票方全称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payee")]
                [System.Text.Json.Serialization.JsonPropertyName("payee")]
                public string Payee { get; set; } = default!;

                /// <summary>
                /// 获取或设置开票详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail")]
                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                public string Detail { get; set; } = default!;

                /// <summary>
                /// 获取或设置发票信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_info")]
                [System.Text.Json.Serialization.JsonPropertyName("user_info")]
                public Types.Invoice Invoice { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置发票卡券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_list")]
        [System.Text.Json.Serialization.JsonPropertyName("item_list")]
        public Types.InvoiceCard[] InvoiceCardList { get; set; } = default!;
    }
}
