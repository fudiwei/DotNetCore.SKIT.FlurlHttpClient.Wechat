namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/updaterole 接口的请求。</para>
    /// </summary>
    public class PromoterUpdateRoleRequest : PublisherStatSettlementRequest, IInferable<PromoterUpdateRoleRequest, PromoterUpdateRoleResponse>
    {
        /// <summary>
        /// 获取或设置角色 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_id")]
        [System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public int RoleId { get; set; }

        /// <summary>
        /// 获取或设置角色名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置角色描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string? Description { get; set; }
    }
}
