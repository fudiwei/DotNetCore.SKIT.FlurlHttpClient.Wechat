namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/register/check_audit_status 接口的请求。</para>
    /// </summary>
    public class ProductRegisterCheckAuditStatusRequest : WechatApiRequest, IMapResponse<ProductRegisterCheckAuditStatusRequest, ProductRegisterCheckAuditStatusResponse>
    {
        /// <summary>
        /// 获取或设置微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_name")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_name")]
        public string Wxname { get; set; } = string.Empty;
    }
}
