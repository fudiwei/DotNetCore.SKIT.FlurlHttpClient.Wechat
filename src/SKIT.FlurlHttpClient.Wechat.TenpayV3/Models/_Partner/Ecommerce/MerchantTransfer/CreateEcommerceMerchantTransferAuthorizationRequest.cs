using System;
using System.Collections.Generic;

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
                public string AgreementCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置协议版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agreement_version")]
                [System.Text.Json.Serialization.JsonPropertyName("agreement_version")]
                public string AgreementVersion { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置签约主体。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sign_organization")]
                [System.Text.Json.Serialization.JsonPropertyName("sign_organization")]
                public string SignOrganization { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置签约时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sign_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("sign_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset SignTime { get; set; } 
            }
        }

        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置签约协议列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agreement_list")]
        [System.Text.Json.Serialization.JsonPropertyName("agreement_list")]
        public IList<Types.Agreement> AgreementList { get; set; } = new List<Types.Agreement>();
    }
}
