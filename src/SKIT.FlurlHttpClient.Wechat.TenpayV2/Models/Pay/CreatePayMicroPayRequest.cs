using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/micropay 接口的请求。</para>
    /// </summary>
    public class CreatePayMicroPayRequest : WechatTenpaySignableRequest
    {
        public static class Types
        {
            public class Detail : CreatePayUnifiedOrderRequest.Types.Detail
            {
            }

            public class Scene : CreatePayUnifiedOrderRequest.Types.Scene
            {
            }
        }

        internal static class Converters
        {
            internal class RequestPropertyDetailNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Detail>
            {
            }

            internal class RequestPropertyDetailSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Detail>
            {
            }

            internal class RequestPropertySceneNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Scene>
            {
            }

            internal class RequestPropertySceneSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Scene>
            {
            }
        }

        /// <summary>
        /// 获取或设置接口版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

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
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

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
        /// 获取或设置付款码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_code")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_code")]
        public string AuthCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置终端设备号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_info")]
        [System.Text.Json.Serialization.JsonPropertyName("device_info")]
        public string? DeviceInfo { get; set; }

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
        /// 获取或设置指定付款方式编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit_pay")]
        [System.Text.Json.Serialization.JsonPropertyName("limit_pay")]
        public string? LimitPayCode { get; set; }

        /// <summary>
        /// 获取或设置交易起始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_start")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_start")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// 获取或设置交易结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_expire")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_expire")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
        public DateTimeOffset? ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertyDetailNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertyDetailSystemTextJsonConverter))]
        public Types.Detail? Detail { get; set; }

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
        /// 获取或设置是否开放电子发票入口。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receipt")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.YesOrNoNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("receipt")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.YesOrNoNullableBooleanConverter))]
        public bool? IsReceiptOpen { get; set; }
    }
}
