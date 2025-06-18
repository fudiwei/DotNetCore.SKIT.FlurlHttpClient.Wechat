using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /password-exempt-contract/contracts/service-id/{service_id}/out-contract-code/{out_contract_code} 接口的响应。</para>
    /// </summary>
    public class GetPasswordExemptContractByOutContractCodeResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Termination
            {
                /// <summary>
                /// 获取或设置解约方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contract_termination_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("contract_termination_mode")]
                public string TerminationMode { get; set; } = default!;

                /// <summary>
                /// 获取或设置解约时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contract_terminated_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("contract_terminated_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? TerminateTime { get; set; }

                /// <summary>
                /// 获取或设置解约备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contract_termination_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("contract_termination_remark")]
                public string? TerminationRemark { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
        public string ServiceId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_contract_code")]
        public string OutContractCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置免密支付协议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_id")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_id")]
        public string ContractId { get; set; } = default!;

        /// <summary>
        /// 获取或设置协议状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_state")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_state")]
        public string ContractState { get; set; } = default!;

        /// <summary>
        /// 获取或设置签署时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_signed_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("contract_signed_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SignTime { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置用户在子商户下的唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户账户展示名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_display_account")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_display_account")]
        public string ContractDisplayAccount { get; set; } = default!;

        /// <summary>
        /// 获取或设置解约信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_terminate_info")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_terminate_info")]
        public Types.Termination? Termination { get; set; }
    }
}
