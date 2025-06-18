using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /vehicle/pay/notification 接口的请求。</para>
    /// </summary>
    public class NotifyVehiclePayRequest : WechatTenpaySignableRequest
    {
        public static class Types
        {
            public class Scene
            {
                public static class Types
                {
                    public class Data
                    {
                        /// <summary>
                        /// 获取或设置入场时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.DigitalDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.DigitalDateTimeOffsetConverter))]
                        public DateTimeOffset StartTime { get; set; }

                        /// <summary>
                        /// 获取或设置车牌号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("plate_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
                        public string? PlateNumber { get; set; }

                        /// <summary>
                        /// 获取或设置车辆类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("car_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("car_type")]
                        public string? CarType { get; set; }

                        /// <summary>
                        /// 获取或设置停车场名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parking_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("parking_name")]
                        public string? ParkingName { get; set; }

                        /// <summary>
                        /// 获取或设置车位编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("space_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("space_number")]
                        public string? SpaceNumber { get; set; }

                        /// <summary>
                        /// 获取或设置免费时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("free_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("free_time")]
                        public int? FreeDuration { get; set; }

                        /// <summary>
                        /// 获取或设置用户的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("openid")]
                        [System.Text.Json.Serialization.JsonPropertyName("openid")]
                        public string? OpenId { get; set; }

                        /// <summary>
                        /// 获取或设置用户在子商户下的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_openid")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
                        public string? SubOpenId { get; set; }

                        /// <summary>
                        /// 获取或设置通知地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("notify_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
                        public string? NotifyUrl { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置停车信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene_info")]
                [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
                public Types.Data Data { get; set; } = new Types.Data();
            }
        }

        /// <summary>
        /// 获取或设置接口版本号。
        /// <para>默认值：3.0</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public string Version { get; set; } = "3.0";

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public override string? AppId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// <para>默认值：<see cref="Constants.SignTypes.HMAC_SHA256"/></para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_type")]
#pragma warning disable CS8765
        public override string SignType { get; set; } = Constants.SignTypes.HMAC_SHA256;
#pragma warning restore CS8765

        /// <summary>
        /// 获取或设置交易场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_scene")]
        public string TradeScene { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public Types.Scene? Scene { get; set; }
    }
}
