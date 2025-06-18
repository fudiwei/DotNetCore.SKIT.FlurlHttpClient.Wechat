using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/qic/inspect/register_logistics 接口的请求。</para>
    /// </summary>
    public class ChannelsECQICInspectRegisterLogisticsRequest : WechatApiRequest, IInferable<ChannelsECQICInspectRegisterLogisticsRequest, ChannelsECQICInspectRegisterLogisticsResponse>
    {
        public static class Types
        {
            public class LogisticsInfo
            {
                /// <summary>
                /// 获取或设置快递单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("waybill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                public string WaybillId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置发货方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_type")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_type")]
                public int DeliveryType { get; set; }

                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string? DeliveryId { get; set; }

                /// <summary>
                /// 获取或设置快递公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_name")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_name")]
                public string? DeliveryName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置快递物流信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id_list")]
        public IList<string> OrderIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_info")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_info")]
        public Types.LogisticsInfo LogisticsInfo { get; set; } = new Types.LogisticsInfo();
    }
}
