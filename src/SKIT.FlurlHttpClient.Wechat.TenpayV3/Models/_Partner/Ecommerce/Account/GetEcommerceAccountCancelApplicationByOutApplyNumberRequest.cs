namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/account/cancel-applications/out-apply-no/{out_apply_no} 接口的请求。</para>
    /// </summary>
    public class GetEcommerceAccountCancelApplicationByOutApplyNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户注销申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutApplyNumber { get; set; } = string.Empty;
    }
}
