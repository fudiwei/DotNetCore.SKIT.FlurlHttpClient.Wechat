using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /user-order/combine-orders 接口的请求。</para>
    /// </summary>
    public class UserOrderCombineOrdersRequest : WechatApiRequest, IInferable<UserOrderCombineOrdersRequest, UserOrderCombineOrdersResponse>
    {
        public static class Types
        {
            public class OrderKey : UserOrderOrdersRequest.Types.OrderKey
            {
            }

            public class SubOrder
            {
                public static class Types
                {
                    public class JumpLink : UserOrderOrdersRequest.Types.Order.Types.JumpLink
                    {
                    }

                    public class Item : UserOrderOrdersRequest.Types.Order.Types.Item
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
                /// 获取或设置商户交易订单编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_order_no")]
                public string MerchantOrderNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商户交易订单详情页链接信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_detail_jump_link")]
                [System.Text.Json.Serialization.JsonPropertyName("order_detail_jump_link")]
                public Types.JumpLink? OrderDetailJumpLink { get; set; }

                /// <summary>
                /// 获取或设置订单购买的商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_list")]
                [System.Text.Json.Serialization.JsonPropertyName("item_list")]
                public IList<Types.Item> ItemList { get; set; } = new List<Types.Item>();

                /// <summary>
                /// 获取或设置物流形式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logistics_type")]
                [System.Text.Json.Serialization.JsonPropertyName("logistics_type")]
                public string? LogisticsType { get; set; }
            }

            public class Payer : UserOrderOrdersRequest.Types.Payer
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("upload_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset UploadTime { get; set; }
    }
}
