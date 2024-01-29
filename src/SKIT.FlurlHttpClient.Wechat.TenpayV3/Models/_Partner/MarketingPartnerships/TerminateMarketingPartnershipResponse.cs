using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partnerships/terminate 接口的响应。</para>
    /// </summary>
    public class TerminateMarketingPartnershipResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置终止合作关系时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("terminate_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("terminate_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset TerminateTime { get; set; }
    }
}
