namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/deliverycompanylist/new/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderDeliveryCompanyListNewGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class DeliveryCompany : ChannelsECOrderDeliveryCompanyListGetResponse.Types.DeliveryCompany
            {
            }
        }

        /// <summary>
        /// 获取或设置快递公司列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_list")]
        [System.Text.Json.Serialization.JsonPropertyName("company_list")]
        public Types.DeliveryCompany[] DeliveryCompanyList { get; set; } = default!;
    }
}
