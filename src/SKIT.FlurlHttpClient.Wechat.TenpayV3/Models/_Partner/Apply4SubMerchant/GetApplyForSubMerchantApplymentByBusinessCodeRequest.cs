namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /applyment4sub/applyment/business_code/{business_code} 接口的请求。</para>
    /// </summary>
    public class GetApplyForSubMerchantApplymentByBusinessCodeRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BusinessCode { get; set; } = string.Empty;
    }
}
