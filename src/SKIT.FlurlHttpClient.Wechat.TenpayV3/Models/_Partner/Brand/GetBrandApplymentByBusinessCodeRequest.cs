namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/applyments/business-code/{business_code} 接口的请求。</para>
    /// </summary>
    public class GetBrandApplymentByBusinessCodeRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户业务申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? BusinessCode { get; set; }
    }
}
