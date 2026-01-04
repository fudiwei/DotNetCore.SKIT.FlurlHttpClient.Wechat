using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/deliveryinfo/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderDeliveryInfoUpdateRequest : WechatApiRequest, IInferable<ChannelsECOrderDeliveryInfoUpdateRequest, ChannelsECOrderDeliveryInfoUpdateResponse>
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

            public class ChangeInfo
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
                        public string WaybillId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_infos")]
                        public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();
                    }
                }

                /// <summary>
                /// 获取或设置包裹原物流信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("old")]
                [System.Text.Json.Serialization.JsonPropertyName("old")]
                public Types.Delivery Old { get; set; } = new Types.Delivery();

                /// <summary>
                /// 获取或设置包裹新物流信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new")]
                [System.Text.Json.Serialization.JsonPropertyName("new")]
                public Types.Delivery New { get; set; } = new Types.Delivery();
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置整单物流信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_list")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_list")]
        public IList<Types.Delivery>? DeliveryList { get; set; }

        /// <summary>
        /// 获取或设置更新包裹物流信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("change_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("change_infos")]
        public IList<Types.ChangeInfo>? ChangeInfoList { get; set; }
    }
}
