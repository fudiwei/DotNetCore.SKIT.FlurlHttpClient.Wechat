namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/updatepromoter 接口的请求。</para>
    /// </summary>
    public class PromoterUpdatePromoterRequest : PublisherStatSettlementRequest, IInferable<PromoterUpdatePromoterRequest, PromoterUpdatePromoterResponse>
    {
        /// <summary>
        /// 获取或设置推广员 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string PromoterId { get; set; } = string.Empty;

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
        /// 获取或设置推广员参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_info")]
        [System.Text.Json.Serialization.JsonPropertyName("extra_info")]
        public string? ExtraInfo { get; set; }

        /// <summary>
        /// 获取或设置推广员名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置推广员手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        [System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置商家声明状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("decl_status")]
        [System.Text.Json.Serialization.JsonPropertyName("decl_status")]
        public int? DeclareStatus { get; set; }
    }
}
