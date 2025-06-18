namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getpromoter 接口的请求。</para>
    /// </summary>
    public class PromoterGetPromoterRequest : PublisherStatSettlementRequest, IInferable<PromoterGetPromoterRequest, PromoterGetPromoterResponse>
    {
        /// <summary>
        /// 获取或设置推广员的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置角色 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_id")]
        [System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public int? RoleId { get; set; }

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retail_id")]
        [System.Text.Json.Serialization.JsonPropertyName("retail_id")]
        public string? RetailId { get; set; }

        /// <summary>
        /// 获取或设置推广员授权状态变更开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long? BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置推广员授权状态变更结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置推广员授权状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_status")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_status")]
        public int? AuthStatus { get; set; }

        /// <summary>
        /// 获取或设置商家声明状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("decl_status")]
        [System.Text.Json.Serialization.JsonPropertyName("decl_status")]
        public int? DeclareStatus { get; set; }

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
