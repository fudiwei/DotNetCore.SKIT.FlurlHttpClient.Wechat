using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/space_acl_add 接口的请求。</para>
    /// </summary>
    public class CgibinWedriveSpaceACLAddRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Authority : CgibinWedriveSpaceCreateRequest.Types.Authority
            {
            }
        }

        /// <summary>
        /// 获取或设置空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spaceid")]
        [System.Text.Json.Serialization.JsonPropertyName("spaceid")]
        public string SpaceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置空间授权信息表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_info")]
        public IList<Types.Authority> AuthorityList { get; set; } = new List<Types.Authority>();
    }
}
