using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/upload_combined_shipping_info 接口的请求。</para>
    /// </summary>
    public class WxaSecOrderUploadCombinedShippingInfoRequest : WechatApiRequest, IInferable<WxaSecOrderUploadCombinedShippingInfoRequest, WxaSecOrderUploadCombinedShippingInfoResponse>
    {
        public static class Types
        {
            public class OrderKey : WxaSecOrderUploadShippingInfoRequest.Types.OrderKey
            {
            }

            public class Payer : WxaSecOrderUploadShippingInfoRequest.Types.Payer
            {
            }

            public class SubOrder
            {
                public static class Types
                {
                    public class OrderKey : WxaSecOrderUploadShippingInfoRequest.Types.OrderKey
                    {
                    }

                    public class Shipping : WxaSecOrderUploadShippingInfoRequest.Types.Shipping
                    {
                        public static new class Types
                        {
                            public class Contact : WxaSecOrderUploadShippingInfoRequest.Types.Shipping.Types.Contact
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置联系信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact")]
                        public new Types.Contact? Contact { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单标识信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_key")]
                [System.Text.Json.Serialization.JsonPropertyName("order_key")]
                public Types.OrderKey OrderKey { get; set; } = new Types.OrderKey();

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
        /// 获取或设置子单信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_orders")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_orders")]
        public IList<Types.SubOrder> SubOrderList { get; set; } = new List<Types.SubOrder>();

        /// <summary>
        /// 获取或设置上传时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("upload_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset UploadTime { get; set; }
    }
}
