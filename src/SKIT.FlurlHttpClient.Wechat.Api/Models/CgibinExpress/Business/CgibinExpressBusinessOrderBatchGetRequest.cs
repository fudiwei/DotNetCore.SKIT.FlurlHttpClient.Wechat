using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/business/order/batchget 接口的请求。</para>
    /// </summary>
    public class CgibinExpressBusinessOrderBatchGetRequest : WechatApiRequest, IMapResponse<CgibinExpressBusinessOrderBatchGetRequest, CgibinExpressBusinessOrderBatchGetResponse>
    {
        public static class Types
        {
            public class Order
            {
                /// <summary>
                /// 获取或设置商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置运单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("waybill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                public string? WaybillId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public IList<Types.Order> OrderList { get; set; } = new List<Types.Order>();
    }
}
