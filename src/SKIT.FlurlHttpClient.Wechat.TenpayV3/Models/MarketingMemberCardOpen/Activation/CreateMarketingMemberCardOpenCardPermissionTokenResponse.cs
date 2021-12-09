namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/membercard-open/cards/{card_id}/permission-tokens 接口的响应。</para>
    /// </summary>
    public class CreateMarketingMemberCardOpenCardPermissionTokenResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置预授权 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("permission_token")]
        [System.Text.Json.Serialization.JsonPropertyName("permission_token")]
        public string PermissionToken { get; set; } = default!;
    }
}
