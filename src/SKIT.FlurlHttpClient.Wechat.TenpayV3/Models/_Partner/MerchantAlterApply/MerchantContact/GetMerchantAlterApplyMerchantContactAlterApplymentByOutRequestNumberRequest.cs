namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /mchalterapply/mchcontactalterapplyment/merchant/{merchant_code}/out-request-no/{out_request_no} 接口的请求。</para>
    /// </summary>
    public class GetMerchantAlterApplyMerchantContactAlterApplymentByOutRequestNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutRequestNumber { get; set; } = string.Empty;
    }
}
