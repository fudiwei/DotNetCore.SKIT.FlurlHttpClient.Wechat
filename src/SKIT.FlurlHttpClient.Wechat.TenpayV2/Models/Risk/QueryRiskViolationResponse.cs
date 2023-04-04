using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /risk/getviolation 接口的响应。</para>
    /// </summary>
    public class QueryRiskViolationResponse : WechatTenpaySignableResponse
    {
        public static class Types
        {
            public class ViolationList
            {
                /// <summary>
                /// 获取或设置违规记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("violation_records")]
                [System.Text.Json.Serialization.JsonPropertyName("violation_records")]
                public ViolationItem[] Items { get; set; } = default!;

                /// <summary>
                /// 获取或设置违规记录总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_size")]
                [System.Text.Json.Serialization.JsonPropertyName("total_size")]
                public int TotalCount { get; set; }
            }

            public class ViolationItem
            {
                /// <summary>
                /// 获取或设置特约商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_mch_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
                public string SubMerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_name")]
                [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                public string CompanyName { get; set; } = default!;

                /// <summary>
                /// 获取或设置违规类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("illegal_type")]
                [System.Text.Json.Serialization.JsonPropertyName("illegal_type")]
                public string IllegalType { get; set; } = default!;

                /// <summary>
                /// 获取或设置处理方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("handle_method")]
                [System.Text.Json.Serialization.JsonPropertyName("handle_method")]
                public string HandleMethod { get; set; } = default!;

                /// <summary>
                /// 获取或设置处理状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("handle_state")]
                [System.Text.Json.Serialization.JsonPropertyName("handle_state")]
                public string HandleState { get; set; } = default!;

                /// <summary>
                /// 获取或设置处罚时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("punish_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("punish_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset PunishTime { get; set; }
            }
        }

        internal static class Converters
        {
            internal class ResponsePropertyViolationListNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.ViolationList>
            {
            }

            internal class ResponsePropertyViolationListSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.ViolationList>
            {
            }
        }

        /// <summary>
        /// <i>（冗余字段，请忽略）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <i>（冗余字段，请忽略）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置违规记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("violation_records")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyViolationListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("violation_records")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyViolationListSystemTextJsonConverter))]
        public Types.ViolationList ViolationList { get; set; } = default!;
    }
}
