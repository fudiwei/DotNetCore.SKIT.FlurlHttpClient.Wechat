using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Events
{
    /// <summary>
    /// <para>表示扣款服务签约、解约结果通知的模型。</para>
    /// </summary>
    public class PAPContractEvent : WechatTenpayEvent
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

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
        public string ContractCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置委托代扣协议 ID。
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
        /// 获取或设置用户在子商户下的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("change_type")]
        [System.Text.Json.Serialization.JsonPropertyName("change_type")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置请求序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_serial")]
        [System.Text.Json.Serialization.JsonPropertyName("request_serial")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long RequestSerialNumber { get; set; }

        /// <summary>
        /// 获取或设置协议解约方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_termination_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_termination_mode")]
        public int? TerminationMode { get; set; }

        /// <summary>
        /// 获取或设置操作时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("operate_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
        public DateTimeOffset OperateTime { get; set; }

        /// <summary>
        /// 获取或设置协议到期时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_expired_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("contract_expired_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
        public DateTimeOffset? ContractExpireTime { get; set; }
    }
}
