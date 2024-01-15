namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/query_open 接口的响应。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightQueryOpenResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否开通。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_open")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_open")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsOpen { get; set; }
    }
}
