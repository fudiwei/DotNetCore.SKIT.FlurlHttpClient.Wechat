using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /vehicle/etc/transactions/highway 接口的请求。</para>
    /// </summary>
    public class CreateVehicleETCTransactionHighwayRequest : WechatTenpayRequest
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

            public class Highway
            {
                /// <summary>
                /// 获取或设置车牌号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plate_number")]
                [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
                public string PlateNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置入站时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset StartTime { get; set; }

                /// <summary>
                /// 获取或设置出站时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset EndTime { get; set; }

                /// <summary>
                /// 获取或设置通道类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel_type")]
                [System.Text.Json.Serialization.JsonPropertyName("channel_type")]
                public string ChannelType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置车辆类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("car_type")]
                [System.Text.Json.Serialization.JsonPropertyName("car_type")]
                public string CarType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置入口名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entrance")]
                [System.Text.Json.Serialization.JsonPropertyName("entrance")]
                public string? Entrance { get; set; }

                /// <summary>
                /// 获取或设置出口名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exit")]
                [System.Text.Json.Serialization.JsonPropertyName("exit")]
                public string? Exit { get; set; }

                /// <summary>
                /// 获取或设置承载人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("carrying_capacity")]
                [System.Text.Json.Serialization.JsonPropertyName("carrying_capacity")]
                public int? CarryingCapacity { get; set; }

                /// <summary>
                /// 获取或设置荷载范围字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("carrying_range")]
                [System.Text.Json.Serialization.JsonPropertyName("carrying_range")]
                public string? CarryingRangeString { get; set; }
            }

            public class Device
            {
                /// <summary>
                /// 获取或设置商户端设备号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_id")]
                [System.Text.Json.Serialization.JsonPropertyName("device_id")]
                public string? DeviceId { get; set; }

                /// <summary>
                /// 获取或设置商户端设备 IP。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_ip")]
                [System.Text.Json.Serialization.JsonPropertyName("device_ip")]
                public string? DeviceIp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置服务商 AppId。
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
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 ETC 扣费授权协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_id")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_id")]
        public string ContractId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置订单优惠标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_tag")]
        public string? GoodsTag { get; set; }

        /// <summary>
        /// 获取或设置金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount Amount { get; set; } = new Types.Amount();

        /// <summary>
        /// 获取或设置高速信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("highway_info")]
        [System.Text.Json.Serialization.JsonPropertyName("highway_info")]
        public Types.Highway Highway { get; set; } = new Types.Highway();

        /// <summary>
        /// 获取或设置设备信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_info")]
        [System.Text.Json.Serialization.JsonPropertyName("device_info")]
        public Types.Device? Device { get; set; }
    }
}
