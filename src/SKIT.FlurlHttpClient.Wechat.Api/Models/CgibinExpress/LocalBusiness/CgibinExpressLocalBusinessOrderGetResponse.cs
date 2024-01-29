namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/order/get 接口的响应。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessOrderGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Shop
            {
                /// <summary>
                /// 获取或设置配送公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商家 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shopid")]
                [System.Text.Json.Serialization.JsonPropertyName("shopid")]
                public string ShopId { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_result")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_result")]
                public int AuditResult { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置运力返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resultcode")]
        [System.Text.Json.Serialization.JsonPropertyName("resultcode")]
        public int ResultCode { get; set; }

        /// <summary>
        /// 获取或设置运力返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resultmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("resultmsg")]
        public string ResultMessage { get; set; } = default!;

        /// <summary>
        /// 获取或设置配送单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = default!;

        /// <summary>
        /// 获取或设置配送状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置骑手姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rider_name")]
        [System.Text.Json.Serialization.JsonPropertyName("rider_name")]
        public string? RiderName { get; set; }

        /// <summary>
        /// 获取或设置骑手电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rider_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("rider_phone")]
        public string? RiderPhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置骑手位置经度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rider_lng")]
        [System.Text.Json.Serialization.JsonPropertyName("rider_lng")]
        public decimal? RiderLongitude { get; set; }

        /// <summary>
        /// 获取或设置骑手位置纬度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rider_lat")]
        [System.Text.Json.Serialization.JsonPropertyName("rider_lat")]
        public decimal? RiderLatitude { get; set; }

        /// <summary>
        /// 获取或设置预计剩余送达时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reach_time")]
        [System.Text.Json.Serialization.JsonPropertyName("reach_time")]
        public int? ExpectedReachTime { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ResultCode == 0;
        }
    }
}
