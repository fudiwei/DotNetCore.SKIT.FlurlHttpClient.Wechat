using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/business/order/get 接口的响应。</para>
    /// </summary>
    public class CgibinExpressBusinessOrderGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class WaybillData
            {
                /// <summary>
                /// 获取或设置运单信息 Key。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string Key { get; set; } = default!;

                /// <summary>
                /// 获取或设置运单信息 Value。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运单数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_data")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_data")]
        public Types.WaybillData[] WaybillDataList { get; set; } = default!;

        /// <summary>
        /// 获取或设置运单 HTML 内容（已经 Base64 编码）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("print_html")]
        [System.Text.Json.Serialization.JsonPropertyName("print_html")]
        public string? WaybillHtml { get; set; }

        /// <summary>
        /// 获取或设置运单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        public int OrderStatus { get; set; }
    }
}
