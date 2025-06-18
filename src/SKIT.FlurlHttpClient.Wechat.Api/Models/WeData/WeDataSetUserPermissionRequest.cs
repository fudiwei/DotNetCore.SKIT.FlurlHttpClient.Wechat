using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wedata/wedata_set_user_perm 接口的请求。</para>
    /// </summary>
    public class WeDataSetUserPermissionRequest : WechatApiRequest, IInferable<WeDataSetUserPermissionRequest, WeDataSetUserPermissionResponse>
    {
        public static class Types
        {
            public class Permission
            {
                /// <summary>
                /// 获取或设置权限集 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("perm_id")]
                [System.Text.Json.Serialization.JsonPropertyName("perm_id")]
                public string PermissionId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置权限集名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置权限集描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string? Description { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户在服务商系统的唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uid")]
        [System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置权限集列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("perm")]
        [System.Text.Json.Serialization.JsonPropertyName("perm")]
        public IList<Types.Permission> PermissionList { get; set; } = new List<Types.Permission>();
    }
}
