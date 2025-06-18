namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/agent/get_permissions 接口的响应。</para>
    /// </summary>
    public class CgibinAgentGetPermissionsResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置需要添加的权限列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_permissions")]
        [System.Text.Json.Serialization.JsonPropertyName("app_permissions")]
        public string[] AppPermissionList { get; set; } = default!;
    }
}
