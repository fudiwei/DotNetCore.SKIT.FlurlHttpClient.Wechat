﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/vehicle/entrancenotify 接口的请求。</para>
    /// </summary>
    public class NontaxVehicleEntranceNotifyRequest : WechatApiRequest, IInferable<NontaxVehicleEntranceNotifyRequest, NontaxVehicleEntranceNotifyResponse>
    {
        public static class Types
        {
            public class Scene
            {
                /// <summary>
                /// 获取或设置用户进入停车时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置车牌号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plate_number")]
                [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
                public string PlateNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置车辆类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("car_type")]
                [System.Text.Json.Serialization.JsonPropertyName("car_type")]
                public string? CarType { get; set; }

                /// <summary>
                /// 获取或设置回调通知地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notify_url")]
                [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
                public string? NotifyUrl { get; set; }

                /// <summary>
                /// 获取或设置停车场名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parking_name")]
                [System.Text.Json.Serialization.JsonPropertyName("parking_name")]
                public string? ParkingName { get; set; }

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置免费停车时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("free_time")]
                [System.Text.Json.Serialization.JsonPropertyName("free_time")]
                public int? FreeTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置银行 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_id")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_id")]
        public string? BankId { get; set; }

        /// <summary>
        /// 获取或设置清分银行账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_account")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
        public string? BankAccount { get; set; }

        /// <summary>
        /// 获取或设置结算商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_code")]
        [System.Text.Json.Serialization.JsonPropertyName("region_code")]
        public string RegionCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置委托代扣的交易场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_scene")]
        public string TradeScene { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public Types.Scene Scene { get; set; } = new Types.Scene();
    }
}
