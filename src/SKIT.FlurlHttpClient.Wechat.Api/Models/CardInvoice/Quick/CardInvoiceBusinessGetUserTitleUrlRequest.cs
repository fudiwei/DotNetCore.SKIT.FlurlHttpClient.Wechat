namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/biz/getusertitleurl 接口的请求。</para>
    /// </summary>
    public class CardInvoiceBusinessGetUserTitleUrlRequest : WechatApiRequest, IInferable<CardInvoiceBusinessGetUserTitleUrlRequest, CardInvoiceBusinessGetUserTitleUrlResponse>
    {
        /// <summary>
        /// 获取或设置发票抬头。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

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

        /// <summary>
        /// 获取或设置是否用户自己填写。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_fill")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("user_fill")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsUserFill { get; set; }

        /// <summary>
        /// 获取或设置开票码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_title_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_title_id")]
        public string? OutTitleId { get; set; }
    }
}
