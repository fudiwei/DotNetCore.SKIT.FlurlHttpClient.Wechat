namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wedata/wedata_get_perm_list 接口的响应。</para>
    /// </summary>
    public class WeDataGetPermissionListResponse : WechatApiResponse
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
                public string PermissionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置权限集名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置权限集描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string Description { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置权限集列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("perm")]
        [System.Text.Json.Serialization.JsonPropertyName("perm")]
        public Types.Permission[] PermissionList { get; set; } = default!;
    }
}
