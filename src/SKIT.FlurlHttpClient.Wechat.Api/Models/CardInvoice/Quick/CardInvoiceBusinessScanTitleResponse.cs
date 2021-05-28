using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/scantitle 接口的响应。</para>
    /// </summary>
    public class CardInvoiceBusinessScanTitleResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置发票抬头类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title_type")]
        [System.Text.Json.Serialization.JsonPropertyName("title_type")]
        public int TitleType { get; set; }

        /// <summary>
        /// 获取或设置发票抬头。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置税号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tax_no")]
        [System.Text.Json.Serialization.JsonPropertyName("tax_no")]
        public string? TaxNumber { get; set; }

        /// <summary>
        /// 获取或设置联系电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        [System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置联系地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addr")]
        [System.Text.Json.Serialization.JsonPropertyName("addr")]
        public string? Address { get; set; }

        /// <summary>
        /// 获取或设置开户行。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
        public string? Bank { get; set; }

        /// <summary>
        /// 获取或设置银行账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_no")]
        public string? BankNumber { get; set; }
    }
}
