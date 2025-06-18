namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getrole 接口的请求。</para>
    /// </summary>
    public class PromoterGetRoleRequest : PublisherStatSettlementRequest, IInferable<PromoterGetRoleRequest, PromoterGetRoleResponse>
    {
        /// <summary>
        /// 获取或设置角色 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_id")]
        [System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public int? RoleId { get; set; }
    }
}
