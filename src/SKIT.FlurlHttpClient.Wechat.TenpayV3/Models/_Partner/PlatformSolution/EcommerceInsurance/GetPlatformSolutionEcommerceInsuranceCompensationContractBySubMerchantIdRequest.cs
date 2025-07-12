namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /platsolution/ecommerce/insurance-compensation-contracts/sub-mchid/{sub_mchid}/check-opened 接口的请求。</para>
    /// </summary>
    public class GetPlatformSolutionEcommerceInsuranceCompensationContractBySubMerchantIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;
    }
}
