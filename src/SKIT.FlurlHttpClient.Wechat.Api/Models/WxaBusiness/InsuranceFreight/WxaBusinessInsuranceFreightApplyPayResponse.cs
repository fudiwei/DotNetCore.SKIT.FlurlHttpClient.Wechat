namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/applypay 接口的响应。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightApplyPayResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置充值链接	。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_url")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_url")]
        public string PayUrl { get; set; } = default!;
    }
}
