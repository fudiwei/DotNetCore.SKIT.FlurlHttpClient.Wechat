namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/permissions 接口的响应。</para>
    /// </summary>
    public class ApplyPayScorePermissionsResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置预授权 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_permissions_token")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_permissions_token")]
        public string ApplyPermissionsToken { get; set; } = default!;
    }
}
