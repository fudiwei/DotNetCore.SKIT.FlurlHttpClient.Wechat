namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/api_wxa_querynickname 接口的请求。</para>
    /// </summary>
    public class WxaApiWxaQueryNicknameRequest : WechatApiRequest, IInferable<WxaApiWxaQueryNicknameRequest, WxaApiWxaQueryNicknameResponse>
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_id")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
        public int? AuditId { get; set; }
    }
}
