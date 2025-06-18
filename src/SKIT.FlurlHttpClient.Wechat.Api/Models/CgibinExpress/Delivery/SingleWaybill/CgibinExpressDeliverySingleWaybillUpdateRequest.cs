namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/single_waybill/update 接口的请求。</para>
    /// </summary>
    public class CgibinExpressDeliverySingleWaybillUpdateRequest : WechatApiRequest, IInferable<CgibinExpressDeliverySingleWaybillUpdateRequest, CgibinExpressDeliverySingleWaybillUpdateResponse>
    {
        /// <summary>
        /// 获取或设置微信订单 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置轨迹节点时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_time")]
        [System.Text.Json.Serialization.JsonPropertyName("action_time")]
        public long ActionTimestamp { get; set; }

        /// <summary>
        /// 获取或设置轨迹节点类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_type")]
        [System.Text.Json.Serialization.JsonPropertyName("action_type")]
        public int ActionType { get; set; }

        /// <summary>
        /// 获取或设置轨迹节点详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("action_msg")]
        public string ActionMessage { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置取件员姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pickup_courier_name")]
        [System.Text.Json.Serialization.JsonPropertyName("pickup_courier_name")]
        public string? PickupCourierName { get; set; }

        /// <summary>
        /// 获取或设置取件员电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pickup_courier_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("pickup_courier_phone")]
        public string? PickupCourierPhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置派件员姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_courier_name")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_courier_name")]
        public string? DeliveryCourierName { get; set; }

        /// <summary>
        /// 获取或设置派件员电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_courier_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_courier_phone")]
        public string? DeliveryCourierPhoneNumber { get; set; }
    }
}
