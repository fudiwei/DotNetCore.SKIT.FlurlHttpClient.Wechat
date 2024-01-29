using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models.Abstractions
{
    public abstract class CommonFilter
    {
        public const string OPERATOR_EQUALS = "EQUALS";
        public const string OPERATOR_CONTAINS = "CONTAINS";
        public const string OPERATOR_LESS = "LESS";
        public const string OPERATOR_LESSEQUALS = "LESS_EQUALS";
        public const string OPERATOR_GREATER = "GREATER";
        public const string OPERATOR_GREATEREQUALS = "GREATER_EQUALS";

        /// <summary>
        /// 获取或设置过滤字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("field")]
        [System.Text.Json.Serialization.JsonPropertyName("field")]
        public string Field { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作符。
        /// <para>默认值："EQUALS"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator")]
        [System.Text.Json.Serialization.JsonPropertyName("operator")]
        public string Operator { get; set; } = OPERATOR_EQUALS;

        /// <summary>
        /// 获取或设置字段取值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("values")]
        [System.Text.Json.Serialization.JsonPropertyName("values")]
        public IList<string> Values { get; set; } = new List<string>();
    }
}
