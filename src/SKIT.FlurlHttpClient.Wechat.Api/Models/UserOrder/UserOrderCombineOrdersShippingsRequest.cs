using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /user-order/combine-orders/shippings 接口的请求。</para>
    /// </summary>
    public class UserOrderCombineOrdersShippingsRequest : WechatApiRequest, IInferable<UserOrderCombineOrdersShippingsRequest, UserOrderCombineOrdersShippingsResponse>
    {
        public static class Types
        {
            public class OrderKey : UserOrderOrdersShippingsRequest.Types.OrderKey
            {
            }

            public class SubOrder
            {
                public static class Types
                {
                    public class Shipping : UserOrderOrdersShippingsRequest.Types.Shipping
                    {
                    }
                }

                /// <summary>
                /// 获取或设置子订单标识信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_key")]
                [System.Text.Json.Serialization.JsonPropertyName("order_key")]
                public OrderKey OrderKey { get; set; } = new OrderKey();

                /// <summary>
                /// 获取或设置物流信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_list")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_list")]
                public IList<Types.Shipping> ShippingList { get; set; } = new List<Types.Shipping>();

                /// <summary>
                /// 获取或设置发货模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_mode")]
                public string DeliveryMode { get; set; } = string.Empty;
            }

            public class Payer : UserOrderOrdersShippingsRequest.Types.Payer
            {
            }
        }

        /// <summary>
        /// 获取或设置合单订单标识信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_key")]
        [System.Text.Json.Serialization.JsonPropertyName("order_key")]
        public Types.OrderKey OrderKey { get; set; } = new Types.OrderKey();

        /// <summary>
        /// 获取或设置子单购物详情列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_orders")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_orders")]
        public IList<Types.SubOrder> SubOrderList { get; set; } = new List<Types.SubOrder>();

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer Payer { get; set; } = new Types.Payer();

        /// <summary>
        /// 获取或设置上传时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("upload_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset UploadTime { get; set; }
    }
}
