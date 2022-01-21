using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /payitil/report 接口的请求。</para>
    /// </summary>
    public class SubmitPayITILReportRequest : WechatTenpaySignableRequest
    {
        public static class Types
        {
            public class Trade
            {
                /// <summary>
                /// 获取或设置商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                public string OutTradeNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置交易开始时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
                public DateTimeOffset? BeginTime { get; set; }

                /// <summary>
                /// 获取或设置交易完成时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
                public DateTimeOffset? EndTime { get; set; }

                /// <summary>
                /// 获取或设置交易状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public string? State { get; set; }

                /// <summary>
                /// 获取或设置错误描述信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("err_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
                public string? ErrorMessage { get; set; }
            }
        }

        internal static class Converters
        {
            internal class ResponsePropertyTradeListNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<Types.Trade>>
            {
            }

            internal class ResponsePropertyTradeListSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<Types.Trade>>
            {
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置终端设备号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_info")]
        [System.Text.Json.Serialization.JsonPropertyName("device_info")]
        public string? DeviceInfo { get; set; }

        /// <summary>
        /// 获取或设置访问接口 IP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_ip")]
        [System.Text.Json.Serialization.JsonPropertyName("user_ip")]
        public string UserIp { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单优惠标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("interface_url")]
        [System.Text.Json.Serialization.JsonPropertyName("interface_url")]
        public string InterfaceUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上报交易数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trades")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyTradeListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("trades")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyTradeListSystemTextJsonConverter))]
        public IList<Types.Trade> TradeList { get; set; } = new List<Types.Trade>();
    }
}
