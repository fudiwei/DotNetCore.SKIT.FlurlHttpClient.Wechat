namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/audit/get_miniapp_certificate 接口的请求。</para>
    /// </summary>
    public class ShopAuditGetMiniAppCertificateRequest : WechatApiRequest, IInferable<ShopAuditGetMiniAppCertificateRequest, ShopAuditGetMiniAppCertificateResponse>
    {
        /// <summary>
        /// 获取或设置请求类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req_type")]
        [System.Text.Json.Serialization.JsonPropertyName("req_type")]
        public int RequestType { get; set; }
    }
}
