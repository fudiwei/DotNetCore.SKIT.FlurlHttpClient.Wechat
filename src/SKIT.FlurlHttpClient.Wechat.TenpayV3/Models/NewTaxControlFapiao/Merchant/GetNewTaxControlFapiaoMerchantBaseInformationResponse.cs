namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /new-tax-control-fapiao/merchant/base-information 接口的响应。</para>
    /// </summary>
    public class GetNewTaxControlFapiaoMerchantBaseInformationResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Seller
            {
                /// <summary>
                /// 获取或设置销售方名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置纳税人识别号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("taxpayer_id")]
                [System.Text.Json.Serialization.JsonPropertyName("taxpayer_id")]
                public string TaxpayerId { get; set; } = default!;

                /// <summary>
                /// 获取或设置地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string? Address { get; set; }

                /// <summary>
                /// 获取或设置电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("telephone")]
                [System.Text.Json.Serialization.JsonPropertyName("telephone")]
                public string? PhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置开户银行。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                public string? BankName { get; set; }

                /// <summary>
                /// 获取或设置银行账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
                public string? BankAccountNumber { get; set; }
            }

            public class Extra
            {
                /// <summary>
                /// 获取或设置收款人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payee")]
                [System.Text.Json.Serialization.JsonPropertyName("payee")]
                public string? Payee { get; set; }

                /// <summary>
                /// 获取或设置复核人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reviewer")]
                [System.Text.Json.Serialization.JsonPropertyName("reviewer")]
                public string? Reviewer { get; set; }

                /// <summary>
                /// 获取或设置开票人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("drawer")]
                [System.Text.Json.Serialization.JsonPropertyName("drawer")]
                public string Drawer { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置销售方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_information")]
        [System.Text.Json.Serialization.JsonPropertyName("seller_information")]
        public Types.Seller Seller { get; set; } = default!;

        /// <summary>
        /// 获取或设置额外信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_information")]
        [System.Text.Json.Serialization.JsonPropertyName("extra_information")]
        public Types.Extra Extra { get; set; } = default!;
    }
}
