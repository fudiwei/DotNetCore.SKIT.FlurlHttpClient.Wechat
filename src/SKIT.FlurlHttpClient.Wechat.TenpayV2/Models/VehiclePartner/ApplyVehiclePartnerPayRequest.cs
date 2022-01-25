using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /vehicle/partnerpay/payapply 接口的请求。</para>
    /// </summary>
    public class ApplyVehiclePartnerPayRequest : WechatTenpaySignableRequest
    {
        public static class Types
        {
            public class Scene
            {
                public static class Types
                {
                    public class Data : NotifyVehiclePartnerPayRequest.Types.Scene.Types.Data
                    {
                        /// <summary>
                        /// 获取或设置出场时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? EndTime { get; set; }

                        /// <summary>
                        /// 获取或设置支持的扣费方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("support_deduct_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("support_deduct_mode")]
                        public string? SupportDeductMode { get; set; }

                        /// <summary>
                        /// 获取或设置发起扣费方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deduct_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("deduct_mode")]
                        public string? DeductMode { get; set; }

                        /// <summary>
                        /// 获取或设置计费时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("charging_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("charging_time")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? ChargingTime { get; set; }

                        /// <summary>
                        /// 获取或设置加油站名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gas_station")]
                        [System.Text.Json.Serialization.JsonPropertyName("gas_station")]
                        public string? GasStation { get; set; }

                        /// <summary>
                        /// 获取或设置油品标号名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gas_label_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("gas_label_name")]
                        public string? GasLabelName { get; set; }

                        /// <summary>
                        /// 获取或设置油品类型名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gas_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("gas_type")]
                        public string? GasType { get; set; }

                        /// <summary>
                        /// 获取或设置油品标准。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gas_standard")]
                        [System.Text.Json.Serialization.JsonPropertyName("gas_standard")]
                        public string? GasStandard { get; set; }

                        /// <summary>
                        /// 获取或设置油量（单位：毫升）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gas_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("gas_amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? GasAmount { get; set; }

                        /// <summary>
                        /// 获取或设置油枪号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gas_gun_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("gas_gun_no")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? GasGunNumber { get; set; }

                        /// <summary>
                        /// 获取或设置入口名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("entrance_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("entrance_name")]
                        public string? EntranceName { get; set; }

                        /// <summary>
                        /// 获取或设置出口名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exit_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("exit_name")]
                        public string? ExitName { get; set; }

                        /// <summary>
                        /// 获取或设置核载人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("carrying_capacity")]
                        [System.Text.Json.Serialization.JsonPropertyName("carrying_capacity")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? CarryingCapacity { get; set; }

                        /// <summary>
                        /// 获取或设置核载区间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("carrying_range")]
                        [System.Text.Json.Serialization.JsonPropertyName("carrying_range")]
                        public string? CarryingRangeString { get; set; }

                        /// <summary>
                        /// 获取或设置通道类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("channel_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("channel_type")]
                        public string? ChannelType { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置场景信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene_info")]
                [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
                public Types.Data Data { get; set; } = new Types.Data();
            }
        }

        internal static class Converters
        {
            internal class RequestPropertySceneNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Scene>
            {
            }

            internal class RequestPropertySceneSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Scene>
            {
            }
        }

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
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置接口版本号。
        /// <para>默认值：3.0</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public string Version { get; set; } = "3.0";

        /// <summary>
        /// 获取或设置商品描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("body")]
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public string Body { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("total_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalFee { get; set; }

        /// <summary>
        /// 获取或设置货币类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee_type")]
        [System.Text.Json.Serialization.JsonPropertyName("fee_type")]
        public string? FeeType { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置交易类型。
        /// <para>默认值：PAP</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
        public string TradeType { get; set; } = "PAP";

        /// <summary>
        /// 获取或设置交易场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_scene")]
        public string TradeScene { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置用户终端 IP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spbill_create_ip")]
        [System.Text.Json.Serialization.JsonPropertyName("spbill_create_ip")]
        public string ClientIp { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单优惠标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_tag")]
        public string? GoodsTag { get; set; }

        /// <summary>
        /// 获取或设置通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertySceneNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertySceneSystemTextJsonConverter))]
        public Types.Scene? Scene { get; set; }

        /// <summary>
        /// 获取或设置是否分账。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profit_sharing")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.YesOrNoNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("profit_sharing")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.YesOrNoNullableBooleanConverter))]
        public bool? IsProfitSharing { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// <para>默认值：<see cref="Constants.SignTypes.HMAC_SHA256"/></para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_type")]
#pragma warning disable CS8765
        public override string SignType { get; set; } = Constants.SignTypes.HMAC_SHA256;
#pragma warning restore CS8765
    }
}
