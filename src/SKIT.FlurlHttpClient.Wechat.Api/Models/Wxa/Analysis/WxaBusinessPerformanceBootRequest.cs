using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/performance/boot 接口的请求。</para>
    /// </summary>
    public class WxaBusinessPerformanceBootRequest : WechatApiRequest, IMapResponse<WxaBusinessPerformanceBootRequest, WxaBusinessPerformanceBootResponse>
    {
        public static class Types
        {
            public class TimeRange
            {
                /// <summary>
                /// 获取或设置开始日期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("begin_timestamp")]
                public long BeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置结束日期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("end_timestamp")]
                public long EndTimestamp { get; set; }
            }

            public class Parameter
            {
                /// <summary>
                /// 获取或设置查询条件。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field")]
                [System.Text.Json.Serialization.JsonPropertyName("field")]
                public string Field { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置查询条件的值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置时间跨度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time")]
        [System.Text.Json.Serialization.JsonPropertyName("time")]
        public Types.TimeRange TimeRange { get; set; } = new Types.TimeRange();

        /// <summary>
        /// 获取或设置查询数据的类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("module")]
        [System.Text.Json.Serialization.JsonPropertyName("module")]
        public string Module { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置查询条件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("params")]
        [System.Text.Json.Serialization.JsonPropertyName("params")]
        public IList<Types.Parameter> ParameterList { get; set; } = new List<Types.Parameter>();
    }
}
