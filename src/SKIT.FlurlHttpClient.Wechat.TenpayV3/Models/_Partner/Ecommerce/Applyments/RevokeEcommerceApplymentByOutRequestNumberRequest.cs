namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/applyments/out-request-no/{out_request_no}/revoke 接口的请求。</para>
    /// </summary>
    public class RevokeEcommerceApplymentByOutRequestNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OutRequestNumber { get; set; }
    }
}
