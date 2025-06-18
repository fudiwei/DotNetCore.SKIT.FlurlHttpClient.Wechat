namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/addrole 接口的请求。</para>
    /// </summary>
    public class PromoterAddRoleRequest : PublisherStatSettlementRequest, IInferable<PromoterAddRoleRequest, PromoterAddRoleResponse>
    {
        /// <summary>
        /// 获取或设置角色名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置角色描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string? Description { get; set; }
    }
}
