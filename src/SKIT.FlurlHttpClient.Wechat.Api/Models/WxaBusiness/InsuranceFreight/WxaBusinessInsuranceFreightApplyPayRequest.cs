namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/applypay 接口的请求。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightApplyPayRequest : WechatApiRequest, IInferable<WxaBusinessInsuranceFreightApplyPayRequest, WxaBusinessInsuranceFreightApplyPayResponse>
    {
        /// <summary>
        /// 获取或设置充值订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;
    }
}
