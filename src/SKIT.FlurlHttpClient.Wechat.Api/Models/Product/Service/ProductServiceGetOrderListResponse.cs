using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/service/get_order_list 接口的响应。</para>
    /// </summary>
    public class ProductServiceGetOrderListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ServiceOrder : ProductServiceGetListResponse.Types.Service
            {
                /// <summary>
                /// 获取或设置服务订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("service_order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedStringConverter))]
                public string ServiceOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置规格英文名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("specification_id")]
                [System.Text.Json.Serialization.JsonPropertyName("specification_id")]
                public string SpecificationId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单总价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_price")]
                [System.Text.Json.Serialization.JsonPropertyName("total_price")]
                public int TotalFee { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.CommonDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.CommonDateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("service_order_list")]
        public Types.ServiceOrder[] ServiceOrderList { get; set; } = default!;
    }
}
