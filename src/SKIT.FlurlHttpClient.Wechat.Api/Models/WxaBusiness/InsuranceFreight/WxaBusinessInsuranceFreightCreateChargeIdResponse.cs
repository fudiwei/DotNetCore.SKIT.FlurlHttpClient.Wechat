namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/createchargeid 接口的响应。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightCreateChargeIdResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置充值订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
        public string OrderId { get; set; } = default!;
    }
}
