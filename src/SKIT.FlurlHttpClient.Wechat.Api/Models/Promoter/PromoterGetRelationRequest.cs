namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getrelation 接口的请求。</para>
    /// </summary>
    public class PromoterGetRelationRequest : PublisherStatSettlementRequest, IInferable<PromoterGetRelationRequest, PromoterGetRelationResponse>
    {
        /// <summary>
        /// 获取或设置推广员的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string PromoterOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置触达场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public int? Scene { get; set; }

        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? PagePath { get; set; }

        /// <summary>
        /// 获取或设置消息开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long? BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置触达结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置分页起始 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_id")]
        [System.Text.Json.Serialization.JsonPropertyName("start_id")]
        public string? StartId { get; set; }

        /// <summary>
        /// 获取或设置是否返回 UnionID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_unionid")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("need_unionid")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsReturnUnionId { get; set; }

    }
}
