using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /user-order/orders/shippings 接口的请求。</para>
    /// </summary>
    public class UserOrderOrdersShippingsRequest : WechatApiRequest, IInferable<UserOrderOrdersShippingsRequest, UserOrderOrdersShippingsResponse>
    {
        public static class Types
        {
            public class OrderKey : UserOrderOrdersRequest.Types.OrderKey
            {
            }

            public class Shipping
            {
                public static class Types
                {
                    public class Contact
                    {
                        /// <summary>
                        /// 获取或设置寄件人联系方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consignor_contact")]
                        [System.Text.Json.Serialization.JsonPropertyName("consignor_contact")]
                        public string? ConsignorContact { get; set; }

                        /// <summary>
                        /// 获取或设置收件人联系方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receiver_contact")]
                        [System.Text.Json.Serialization.JsonPropertyName("receiver_contact")]
                        public string? ReceiverContact { get; set; }
                    }

                    public class Item
                    {
                        /// <summary>
                        /// 获取或设置商户侧商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_item_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_item_id")]
                        public string MerchantItemId { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置物流公司编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("express_company")]
                [System.Text.Json.Serialization.JsonPropertyName("express_company")]
                public string ExpressCompanyCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置物流单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tracking_no")]
                [System.Text.Json.Serialization.JsonPropertyName("tracking_no")]
                public string TrackingNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact")]
                [System.Text.Json.Serialization.JsonPropertyName("contact")]
                public Types.Contact? Contact { get; set; }

                /// <summary>
                /// 获取或设置订单购买的商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_list")]
                [System.Text.Json.Serialization.JsonPropertyName("item_list")]
                public IList<Types.Item>? ItemList { get; set; }
            }

            public class Payer : UserOrderOrdersRequest.Types.Payer
            {
            }
        }

        /// <summary>
        /// 获取或设置订单标识信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_key")]
        [System.Text.Json.Serialization.JsonPropertyName("order_key")]
        public Types.OrderKey OrderKey { get; set; } = new Types.OrderKey();

        /// <summary>
        /// 获取或设置物流信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipping_list")]
        [System.Text.Json.Serialization.JsonPropertyName("shipping_list")]
        public IList<Types.Shipping> ShippingList { get; set; } = new List<Types.Shipping>();

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer Payer { get; set; } = new Types.Payer();

        /// <summary>
        /// 获取或设置发货模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_mode")]
        public string DeliveryMode { get; set; } = string.Empty;

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
