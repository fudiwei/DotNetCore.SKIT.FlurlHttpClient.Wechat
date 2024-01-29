using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/combine-papay/contracts/plan-id/{plan_id}/out-contract-code/{out_contract_code} 接口的响应。</para>
    /// </summary>
    public class GetEcommerceCombinePAPPayContractByOutContractCodeResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Termination
            {
                /// <summary>
                /// 获取或设置解约时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contract_terminated_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("contract_terminated_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset TerminateTime { get; set; }

                /// <summary>
                /// 获取或设置解约方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contract_termination_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("contract_termination_mode")]
                public string TerminationMode { get; set; } = default!;

                /// <summary>
                /// 获取或设置解约备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contract_termination_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("contract_termination_remark")]
                public string TerminationRemark { get; set; } = default!;
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
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public int PlanId { get; set; }

        /// <summary>
        /// 获取或设置商户签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_contract_code")]
        public string OutContractCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置委托代扣协议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_id")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_id")]
        public string ContractId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户账户展示名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_display_account")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_display_account")]
        public string UserDisplayName { get; set; } = default!;

        /// <summary>
        /// 获取或设置协议状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_state")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置签署时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_signed_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("contract_signed_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset SignTime { get; set; }

        /// <summary>
        /// 获取或设置到期时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_expired_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("contract_expired_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置解约信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_terminate_info")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_terminate_info")]
        public Types.Termination? Termination { get; set; }
    }
}
