namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/servicemarket/service/get_service_buyer 接口的响应。</para>
    /// </summary>
    public class WxaServiceMarketServiceGetServiceBuyerResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Buyer : WxaServiceMarketServiceGetServiceBuyerListResponse.Types.Buyer
            {
            }
        }

        /// <summary>
        /// 获取或设置服务用户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer")]
        public Types.Buyer Buyer { get; set; } = default!;
    }
}
