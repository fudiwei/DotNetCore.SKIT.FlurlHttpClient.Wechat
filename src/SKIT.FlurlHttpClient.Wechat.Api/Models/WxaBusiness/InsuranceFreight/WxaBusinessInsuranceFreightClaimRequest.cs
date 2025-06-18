namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/claim 接口的请求。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightClaimRequest : WechatApiRequest, IInferable<WxaBusinessInsuranceFreightClaimRequest, WxaBusinessInsuranceFreightClaimResponse>
    {
        /// <summary>
        /// 获取或设置买家用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("order_no")]
        public string OrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退款运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_delivery_no")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_delivery_no")]
        public string RefundDeliveryNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退货快递公司。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_company")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_company")]
        public string RefundDeliveryCompany { get; set; } = string.Empty;
    }
}
