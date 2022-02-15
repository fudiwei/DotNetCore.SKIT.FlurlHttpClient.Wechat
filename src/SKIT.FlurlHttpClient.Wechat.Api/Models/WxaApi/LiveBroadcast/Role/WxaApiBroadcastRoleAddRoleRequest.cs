namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/role/addrole 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoleAddRoleRequest : WechatApiRequest, IMapResponse<WxaApiBroadcastRoleAddRoleRequest, WxaApiBroadcastRoleAddRoleResponse>
    {
        /// <summary>
        /// 获取或设置角色类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role")]
        [System.Text.Json.Serialization.JsonPropertyName("role")]
        public int Role { get; set; }

        /// <summary>
        /// 获取或设置用户微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("username")]
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;
    }
}
