using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/funds/scanorderflow 接口的响应。</para>
    /// </summary>
    public class ProductFundsScanOrderFlowResponse : WechatApiResponse
    {
        public static class Types
        {
            public class OrderFlow
            {
                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置商家所得金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public int Price { get; set; }

                /// <summary>
                /// 获取或设置订单总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_price")]
                [System.Text.Json.Serialization.JsonPropertyName("order_price")]
                public int TotalFee { get; set; }

                /// <summary>
                /// 获取或设置打折金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_fee")]
                public int DiscountFee { get; set; }

                /// <summary>
                /// 获取或设置服务费金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("service_fee")]
                public int ServiceFee { get; set; }

                /// <summary>
                /// 获取或设置手续费金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("handling_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("handling_fee")]
                public int HandlingFee { get; set; }

                /// <summary>
                /// 获取或设置退款类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refunding_type")]
                [System.Text.Json.Serialization.JsonPropertyName("refunding_type")]
                public int RefundType { get; set; }

                /// <summary>
                /// 获取或设置已退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_fee")]
                public int RefundFee { get; set; }

                /// <summary>
                /// 获取或设置结算时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settled_time")]
                [System.Text.Json.Serialization.JsonPropertyName("settled_time")]
                public long? SettleTimestamp { get; set; }

                /// <summary>
                /// 获取或设置下单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_time")]
                public long OrderTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单资金流水列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_flow")]
        [System.Text.Json.Serialization.JsonPropertyName("order_flow")]
        public Types.OrderFlow[] OrderFlowList { get; set; } = default!;
    }
}
