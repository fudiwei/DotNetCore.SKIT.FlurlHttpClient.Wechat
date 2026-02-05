using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/delivery/compensation 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderDeliveryCompensationRequest : WechatApiRequest, IInferable<ChannelsECOrderDeliveryCompensationRequest, ChannelsECOrderDeliveryCompensationResponse>
    {
        public static class Types
        {
            public class Delivery
            {
                public static class Types
                {
                    public class Product : ChannelsECOrderDeliverySendRequest.Types.Delivery.Types.Product
                    {
                    }
                }

                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置快递单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("waybill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                public string? WaybillId { get; set; }

                /// <summary>
                /// 获取或设置发货方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deliver_type")]
                [System.Text.Json.Serialization.JsonPropertyName("deliver_type")]
                public int DeliverType { get; set; }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("product_infos")]
                public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_list")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_list")]
        public IList<Types.Delivery> DeliveryList { get; set; } = new List<Types.Delivery>();

        /// <summary>
        /// 获取或设置补发原因类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public int ReasonType { get; set; }
    }
}
