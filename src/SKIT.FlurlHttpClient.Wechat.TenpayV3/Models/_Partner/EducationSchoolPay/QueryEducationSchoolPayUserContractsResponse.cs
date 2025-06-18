using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /eduschoolpay/users/{openid}/contracts 接口的响应。</para>
    /// </summary>
    public class QueryEducationSchoolPayUserContractsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class UserContract
            {
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
                public string PlanId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户签约号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_contract_code")]
                [System.Text.Json.Serialization.JsonPropertyName("out_contract_code")]
                public string OutContractCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置签约协议号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contract_id")]
                [System.Text.Json.Serialization.JsonPropertyName("contract_id")]
                public string ContractId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

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
        /// 获取或设置签约列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.UserContract[] UserContractList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置数据总条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
