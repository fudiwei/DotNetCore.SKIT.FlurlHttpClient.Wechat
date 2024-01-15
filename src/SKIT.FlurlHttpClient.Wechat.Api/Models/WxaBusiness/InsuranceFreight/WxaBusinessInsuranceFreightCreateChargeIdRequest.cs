namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/createchargeid 接口的请求。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightCreateChargeIdRequest : WechatApiRequest, IInferable<WxaBusinessInsuranceFreightCreateChargeIdRequest, WxaBusinessInsuranceFreightCreateChargeIdResponse>
    {
        /// <summary>
        /// 获取或设置充值金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quota")]
        [System.Text.Json.Serialization.JsonPropertyName("quota")]
        public int Amount { get; set; }
    }
}
