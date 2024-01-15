using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/order/batchprint 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillOrderBatchPrintRequest : WechatApiRequest, IInferable<ChannelsECLogisticsEWaybillOrderBatchPrintRequest, ChannelsECLogisticsEWaybillOrderBatchPrintResponse>
    {
        public static class Types
        {
            public class PrintRequest
            {
                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置电子面单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ewaybill_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_id")]
                public string EWaybillOrderId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置快递单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("waybill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                public string WaybillId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置是否是补打单。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("re_print")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("re_print")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsReprint { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置打印请求列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req_list")]
        [System.Text.Json.Serialization.JsonPropertyName("req_list")]
        public IList<Types.PrintRequest> PrintRequestList { get; set; } = new List<Types.PrintRequest>();
    }
}
