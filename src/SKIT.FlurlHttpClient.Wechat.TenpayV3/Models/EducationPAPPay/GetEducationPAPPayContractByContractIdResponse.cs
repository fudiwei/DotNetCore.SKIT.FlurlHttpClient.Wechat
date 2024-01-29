using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /edu-papay/contracts/id/{contract_id} 接口的响应。</para>
    /// </summary>
    public class GetEducationPAPPayContractByContractIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Contract
            {
                /// <summary>
                /// 获取或设置签约协议号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contract_id")]
                [System.Text.Json.Serialization.JsonPropertyName("contract_id")]
                public string ContractId { get; set; } = default!;

                /// <summary>
                /// 获取或设置签约状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contract_status")]
                [System.Text.Json.Serialization.JsonPropertyName("contract_status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置签约时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
            }
        }

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
        public string PlanId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置签约信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_information")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_information")]
        public Types.Contract Contract { get; set; } = default!;
    }
}
