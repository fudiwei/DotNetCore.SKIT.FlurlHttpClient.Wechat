using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/presentorder/receiver/set 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderPresentOrderReceiverSetRequest : WechatApiRequest, IInferable<ChannelsECOrderPresentOrderReceiverSetRequest, ChannelsECOrderPresentOrderReceiverSetResponse>
    {
        public static class Types
        {
            public class SubOrder
            {
                /// <summary>
                /// 获取或设置子单订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置收礼者 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置礼物订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("present_order_id")]
        public string PresentOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_order_list")]
        public IList<Types.SubOrder> SubOrderList { get; set; } = new List<Types.SubOrder>();
    }
}
