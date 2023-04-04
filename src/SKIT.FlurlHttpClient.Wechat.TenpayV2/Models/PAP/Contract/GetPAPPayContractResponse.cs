using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/querycontract 接口的响应。</para>
    /// </summary>
    public class GetPAPPayContractResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string MerchantId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string AppId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户在子商户下的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public int PlanId { get; set; }

        /// <summary>
        /// 获取或设置签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_code")]
        public string Contract { get; set; } = default!;

        /// <summary>
        /// 获取或设置委托代扣协议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_id")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_id")]
        public string ContractId { get; set; } = default!;

        /// <summary>
        /// 获取或设置请求序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_serial")]
        [System.Text.Json.Serialization.JsonPropertyName("request_serial")]
        public long RequestSerialNumber { get; set; }

        /// <summary>
        /// 获取或设置用户账户展示名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_display_account")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_display_account")]
        public string ContractDisplayAccount { get; set; } = default!;

        /// <summary>
        /// 获取或设置协议状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_state")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_state")]
        public string ContractState { get; set; } = default!;

        /// <summary>
        /// 获取或设置协议签署时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_signed_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("contract_signed_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
        public DateTimeOffset ContractSignTime { get; set; } = default!;

        /// <summary>
        /// 获取或设置协议到期时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_expired_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("contract_expired_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
        public DateTimeOffset ContractExpireTime { get; set; } = default!;

        /// <summary>
        /// 获取或设置协议解约方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_termination_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_termination_mode")]
        public int? TerminationMode { get; set; }

        /// <summary>
        /// 获取或设置协议解约备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_termination_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_termination_remark")]
        public string? TerminationRemark { get; set; }

        /// <summary>
        /// 获取或设置协议解约时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_terminated_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("contract_terminated_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? ContractTerminateTime { get; set; }
    }
}
