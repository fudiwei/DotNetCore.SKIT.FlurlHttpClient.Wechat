namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/account/apply-cancel-withdraw/out-request-no/{out_request_no} 接口的请求。</para>
    /// </summary>
    public class GetEcommerceAccountCancelWithdrawApplicationByOutRequestNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户注销申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutRequestNumber { get; set; } = string.Empty;
    }
}
