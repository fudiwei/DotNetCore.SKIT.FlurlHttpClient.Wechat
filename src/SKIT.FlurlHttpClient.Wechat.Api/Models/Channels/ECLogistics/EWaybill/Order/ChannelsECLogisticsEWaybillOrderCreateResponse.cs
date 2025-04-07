namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/order/create 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillOrderCreateResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SubWaybill
            {
                /// <summary>
                /// 获取或设置快递单号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("waybill_type")]
                [System.Text.Json.Serialization.JsonPropertyName("waybill_type")]
                public int? WaybillType { get; set; }

                /// <summary>
                /// 获取或设置快递单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("waybill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                public string? WaybillId { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }

            public class RiskInfo
            {
                public static class Types
                {
                    public class Order
                    {
                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ec_order_id")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("ec_order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置代发的订单密文。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ewaybill_order_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_code")]
                        public string? EWaybillOrderCode { get; set; }

                        /// <summary>
                        /// 获取或设置代发的订单所属店铺 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ewaybill_order_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_appid")]
                        public string? EWaybillOrderAppId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置风险信息内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("risk_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("risk_msg")]
                public string? RiskMessage { get; set; }

                /// <summary>
                /// 获取或设置疑似存在风险的订单目录。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("risk_ec_order_info")]
                [System.Text.Json.Serialization.JsonPropertyName("risk_ec_order_info")]
                public Types.Order[]? OrderList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置电子面单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ewaybill_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_id")]
        public string EWaybillOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置快递单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string? WaybillId { get; set; }

        /// <summary>
        /// 获取或设置快递公司错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_error_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_error_msg")]
        public string? DeliveryErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置打印报文信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("print_info")]
        [System.Text.Json.Serialization.JsonPropertyName("print_info")]
        public string? PrintInfo { get; set; }

        /// <summary>
        /// 获取或设置子单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id_list")]
        public Types.SubWaybill[]? SubWaybillList { get; set; }

        /// <summary>
        /// 获取或设置疑似风险信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_risk_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_risk_info")]
        public Types.RiskInfo? RiskInfo { get; set; }
    }
}
