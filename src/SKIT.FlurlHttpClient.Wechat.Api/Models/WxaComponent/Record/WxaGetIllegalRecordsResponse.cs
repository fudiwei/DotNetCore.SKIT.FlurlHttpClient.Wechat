using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getillegalrecords 接口的响应。</para>
    /// </summary>
    public class WxaGetIllegalRecordsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class IllegalRecord
            {
                /// <summary>
                /// 获取或设置违规处罚记录 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("illegal_record_id")]
                [System.Text.Json.Serialization.JsonPropertyName("illegal_record_id")]
                public string IllegalRecordId { get; set; } = default!;

                /// <summary>
                /// 获取或设置违规原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("illegal_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("illegal_reason")]
                public string IllegalReason { get; set; } = default!;

                /// <summary>
                /// 获取或设置违规内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("illegal_content")]
                [System.Text.Json.Serialization.JsonPropertyName("illegal_content")]
                public string IllegalContent { get; set; } = default!;

                /// <summary>
                /// 获取或设置规则名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rule_name")]
                [System.Text.Json.Serialization.JsonPropertyName("rule_name")]
                public string RuleName { get; set; } = default!;

                /// <summary>
                /// 获取或设置规则链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rule_url")]
                [System.Text.Json.Serialization.JsonPropertyName("rule_url")]
                public string RuleUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置违规处罚时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置违规处罚记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("records")]
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public Types.IllegalRecord[] IllegalRecordList { get; set; } = default!;
    }
}
