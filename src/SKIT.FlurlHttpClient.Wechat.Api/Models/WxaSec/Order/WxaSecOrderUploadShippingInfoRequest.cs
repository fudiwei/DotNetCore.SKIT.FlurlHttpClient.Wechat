using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/upload_shipping_info 接口的请求。</para>
    /// </summary>
    public class WxaSecOrderUploadShippingInfoRequest : WechatApiRequest, IInferable<WxaSecOrderUploadShippingInfoRequest, WxaSecOrderUploadShippingInfoResponse>
    {
        public static class Types
        {
            public class OrderKey : UserOrderOrdersRequest.Types.OrderKey
            {
            }

            public class Payer : UserOrderOrdersRequest.Types.Payer
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
                }

                /// <summary>
                /// 获取或设置物流公司编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("express_company")]
                [System.Text.Json.Serialization.JsonPropertyName("express_company")]
                public string? ExpressCompany { get; set; }

                /// <summary>
                /// 获取或设置物流单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tracking_no")]
                [System.Text.Json.Serialization.JsonPropertyName("tracking_no")]
                public string? TrackingNumber { get; set; }

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("item_desc")]
                public string? ItemDescription { get; set; }

                /// <summary>
                /// 获取或设置联系信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact")]
                [System.Text.Json.Serialization.JsonPropertyName("contact")]
                public Types.Contact? Contact { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单标识信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_key")]
        [System.Text.Json.Serialization.JsonPropertyName("order_key")]
        public Types.OrderKey OrderKey { get; set; } = new Types.OrderKey();

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer Payer { get; set; } = new Types.Payer();

        /// <summary>
        /// 获取或设置物流形式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_type")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_type")]
        public int LogisticsType { get; set; }

        /// <summary>
        /// 获取或设置发货模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_mode")]
        public int DeliveryMode { get; set; }

        /// <summary>
        /// 获取或设置发货模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_all_delivered")]
        [System.Text.Json.Serialization.JsonPropertyName("is_all_delivered")]
        public bool? IsFinishAll { get; set; }

        /// <summary>
        /// 获取或设置物流信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipping_list")]
        [System.Text.Json.Serialization.JsonPropertyName("shipping_list")]
        public IList<Types.Shipping> ShippingList { get; set; } = new List<Types.Shipping>();

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
