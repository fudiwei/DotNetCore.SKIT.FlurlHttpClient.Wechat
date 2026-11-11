namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /mchalterapply/mchsubjectalterapplyment/merchant/{sub_mchid}/out-request-no/{out_request_no} 接口的请求。</para>
    /// </summary>
    public class GetMerchantAlterApplyMerchantSubjectAlterApplymentByOutRequestNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OutRequestNumber { get; set; }
    }
}
