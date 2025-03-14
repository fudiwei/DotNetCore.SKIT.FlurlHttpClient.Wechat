namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/ecommerce/recharge-employees 接口的请求。</para>
    /// </summary>
    public class AddPlatformSolutionEcommerceRechargeEmployeeRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置员工的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_openid")]
        public string OpenId { get; set; } = string.Empty;
    }
}
