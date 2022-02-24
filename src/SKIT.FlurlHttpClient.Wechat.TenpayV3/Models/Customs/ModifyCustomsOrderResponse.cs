using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /customs/orders 接口的响应。</para>
    /// </summary>
    public class ModifyCustomsOrderResponse : CreateCustomsOrderResponse
    {
        /// <summary>
        /// 获取或设置最后更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modify_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ModifyTime { get; set; }
    }
}
