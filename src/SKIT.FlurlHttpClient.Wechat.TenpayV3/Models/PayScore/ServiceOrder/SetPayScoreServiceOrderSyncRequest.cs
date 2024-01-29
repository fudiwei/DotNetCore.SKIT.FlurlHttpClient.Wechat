using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/serviceorder/{out_order_no}/sync 接口的请求。</para>
    /// </summary>
    public class SetPayScoreServiceOrderSyncRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Detail
            {
                /// <summary>
                /// 获取或设置收款序号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seq")]
                [System.Text.Json.Serialization.JsonPropertyName("seq")]
                public int? Sequence { get; set; }

                /// <summary>
                /// 获取或设置收款成功时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.DigitalDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("paid_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.DigitalDateTimeOffsetConverter))]
                public DateTimeOffset? PaidTime { get; set; }

                /// <summary>
                /// 获取或设置收款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("paid_amount")]
                public int? PaidAmount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商户服务订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置场景类型。
        /// <para>默认值：Order_Paid</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "Order_Paid";

        /// <summary>
        /// 获取或设置内容详情信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public Types.Detail? Detail { get; set; }
    }
}
