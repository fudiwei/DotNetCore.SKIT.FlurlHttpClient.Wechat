namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/address/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderAddressUpdateRequest : WechatApiRequest, IInferable<ChannelsECOrderAddressUpdateRequest, ChannelsECOrderAddressUpdateResponse>
    {
        public static class Types
        {
            public class Address : ChannelsECMerchantAddFreightTemplateRequest.Types.FreightTemplate.Types.Address
            {
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置新地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_address")]
        [System.Text.Json.Serialization.JsonPropertyName("user_address")]
        public Types.Address Address { get; set; } = new Types.Address();
    }
}
