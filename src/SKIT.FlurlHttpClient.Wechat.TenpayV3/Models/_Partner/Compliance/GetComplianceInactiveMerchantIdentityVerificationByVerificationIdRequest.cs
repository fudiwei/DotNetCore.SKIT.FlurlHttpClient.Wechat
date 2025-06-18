namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /compliance/inactive-merchant-identity-verification/merchants/{sub_mchid}/verifications/{verification_id} 接口的请求。</para>
    /// </summary>
    public class GetComplianceInactiveMerchantIdentityVerificationByVerificationIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置核实单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string VerificationId { get; set; } = string.Empty;
    }
}
