namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/broadcast/role/getrolelist 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoleGetRoleListRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置搜索的用户微信号或昵称。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Keyword { get; set; }

        /// <summary>
        /// 获取或设置搜索的角色类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Role { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Limit { get; set; }
    }
}
