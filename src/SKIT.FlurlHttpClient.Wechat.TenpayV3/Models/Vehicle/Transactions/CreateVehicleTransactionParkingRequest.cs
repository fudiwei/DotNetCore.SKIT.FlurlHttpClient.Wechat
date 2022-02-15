using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /vehicle/transactions/parking 接口的请求。</para>
    /// </summary>
    public class CreateVehicleTransactionParkingRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Amount
            {
                /// <summary>
                /// 获取或设置总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int Total { get; set; }

                /// <summary>
                /// 获取或设置币种。
                /// <para>默认值：CNY</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string Currency { get; set; } = "CNY";
            }

            public class Parking
            {
                /// <summary>
                /// 获取或设置停车入场 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parking_id")]
                [System.Text.Json.Serialization.JsonPropertyName("parking_id")]
                public string ParkingId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置车牌号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plate_number")]
                [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
                public string PlateNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置车牌颜色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plate_color")]
                [System.Text.Json.Serialization.JsonPropertyName("plate_color")]
                public string PlateColor { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置入场时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset StartTime { get; set; }

                /// <summary>
                /// 获取或设置出场时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset EndTime { get; set; }

                /// <summary>
                /// 获取或设置停车场名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parking_name")]
                [System.Text.Json.Serialization.JsonPropertyName("parking_name")]
                public string ParkingName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置计费时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("charging_duration")]
                [System.Text.Json.Serialization.JsonPropertyName("charging_duration")]
                public int ChargingDuration { get; set; }

                /// <summary>
                /// 获取或设置停车场设备 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_id")]
                [System.Text.Json.Serialization.JsonPropertyName("device_id")]
                public string? DeviceId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置服务描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置交易场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_scene")]
        public string TradeScene { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置订单优惠标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_tag")]
        public string? GoodsTag { get; set; }

        /// <summary>
        /// 获取或设置是否分账。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profit_sharing")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.YesOrNoNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("profit_sharing")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.YesOrNoNullableBooleanConverter))]
        public bool? IsProfitSharing { get; set; }

        /// <summary>
        /// 获取或设置金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount Amount { get; set; } = new Types.Amount();

        /// <summary>
        /// 获取或设置停车信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parking_info")]
        [System.Text.Json.Serialization.JsonPropertyName("parking_info")]
        public Types.Parking Parking { get; set; } = new Types.Parking();
    }
}
