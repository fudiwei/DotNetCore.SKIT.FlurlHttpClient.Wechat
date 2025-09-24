using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/individual-contracts/out-contract-code/{out_contract_code} 接口的响应。</para>
    /// </summary>
    public class GetEcommerceIndividualContractByOutContractCodeResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置签约时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signed_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("signed_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset SignTime { get; set; }

        /// <summary>
        /// 获取或设置授权状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_state")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_state")]
        public string AuthState { get; set; } = default!;

        /// <summary>
        /// 获取或设置个人收款方受理授权 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("individual_auth_id")]
        [System.Text.Json.Serialization.JsonPropertyName("individual_auth_id")]
        public string? IndividualAuthId { get; set; }

        /// <summary>
        /// 获取或设置个人收款方用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("individual_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("individual_openid")]
        public string? IndividualOpenId { get; set; }
    }
}
