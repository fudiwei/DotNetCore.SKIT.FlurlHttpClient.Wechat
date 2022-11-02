namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/deliverycompanylist/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderDeliveryCompanyListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class DeliveryCompany
            {
                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置快递公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_name")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_name")]
                public string DeliveryName { get; set; } = default!;
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
