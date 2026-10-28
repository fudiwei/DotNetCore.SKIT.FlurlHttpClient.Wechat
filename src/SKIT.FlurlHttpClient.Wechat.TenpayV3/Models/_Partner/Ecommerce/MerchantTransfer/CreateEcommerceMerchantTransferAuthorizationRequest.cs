namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/mch-transfer/authorizations 接口的请求。</para>
    /// </summary>
    public class CreateEcommerceMerchantTransferAuthorizationRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Agreement
            {
                /// <summary>
                /// 获取或设置协议编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agreement_code")]
                [System.Text.Json.Serialization.JsonPropertyName("agreement_code")]
                public string? AgreementCode { get; set; }

                /// <summary>
                /// 获取或设置协议版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agreement_version")]
                [System.Text.Json.Serialization.JsonPropertyName("agreement_version")]
                public string? AgreementVersion { get; set; }

                /// <summary>
                /// 获取或设置签约主体。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sign_organization")]
                [System.Text.Json.Serialization.JsonPropertyName("sign_organization")]
                public string? SignOrganization { get; set; }

                /// <summary>
                /// 获取或设置签约时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sign_time")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("sign_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset SignTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置签约协议列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agreement_list")]
        [System.Text.Json.Serialization.JsonPropertyName("agreement_list")]
        public List<Types.Agreement>? AgreementList { get; set; }
    }
}
