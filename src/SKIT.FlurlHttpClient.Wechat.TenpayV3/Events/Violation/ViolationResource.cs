using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 VIOLATION.PUNISH 通知的数据。</para>
    /// <para>表示 VIOLATION.INTERCEPT 通知的数据。</para>
    /// <para>表示 VIOLATION.APPEAL 通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012079216 ]]>
    /// </para>
    /// </summary>
    public class ViolationResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户公司名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_name")]
        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string CompanyName { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户违约处理通知 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_id")]
        [System.Text.Json.Serialization.JsonPropertyName("record_id")]
        public string RecordId { get; set; } = default!;

        /// <summary>
        /// 获取或设置处罚方案。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("punish_plan")]
        [System.Text.Json.Serialization.JsonPropertyName("punish_plan")]
        public string PunishPlan { get; set; } = default!;

        /// <summary>
        /// 获取或设置处罚时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("punish_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("punish_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset PunishTime { get; set; }

        /// <summary>
        /// 获取或设置处罚方案描述信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("punish_description")]
        [System.Text.Json.Serialization.JsonPropertyName("punish_description")]
        public string PunishDescription { get; set; } = default!;

        /// <summary>
        /// 获取或设置风险类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_type")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_type")]
        public string RiskType { get; set; } = default!;

        /// <summary>
        /// 获取或设置风险描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_description")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_description")]
        public string RiskDescription { get; set; } = default!;
    }
}
