namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getinvitationmaterial 接口的请求。</para>
    /// </summary>
    public class PromoterGetInvitationMaterialRequest : PublisherStatSettlementRequest, IInferable<PromoterGetInvitationMaterialRequest, PromoterGetInvitationMaterialResponse>
    {
        /// <summary>
        /// 获取或设置角色 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_id")]
        [System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public int RoleId { get; set; }

        /// <summary>
        /// 获取或设置邀请方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invitation_type")]
        [System.Text.Json.Serialization.JsonPropertyName("invitation_type")]
        public int? InvitationType { get; set; }
    }
}
