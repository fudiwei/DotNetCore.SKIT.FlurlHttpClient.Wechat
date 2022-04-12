using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/getorderflow 接口的响应。</para>
    /// </summary>
    public class ShopFundsGetOrderFlowResponse : WechatApiResponse
    {
        public static class Types
        {
            public class FundsFlow
            {
                /// <summary>
                /// 获取或设置资金流水单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("funds_flow_id")]
                [System.Text.Json.Serialization.JsonPropertyName("funds_flow_id")]
                public string FundsFlowId { get; set; } = default!;

                /// <summary>
                /// 获取或设置资金类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置流水类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("flow_type")]
                [System.Text.Json.Serialization.JsonPropertyName("flow_type")]
                public string FlowType { get; set; } = default!;

                /// <summary>
                /// 获取或设置金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public double Amount { get; set; }

                /// <summary>
                /// 获取或设置余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance")]
                [System.Text.Json.Serialization.JsonPropertyName("balance")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public double Balance { get; set; }

                /// <summary>
                /// 获取或设置业务类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("busi_type")]
                [System.Text.Json.Serialization.JsonPropertyName("busi_type")]
                public string? BusinessType { get; set; }

                /// <summary>
                /// 获取或设置业务单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("request_no")]
                [System.Text.Json.Serialization.JsonPropertyName("request_no")]
                public string? RequestNumber { get; set; }

                /// <summary>
                /// 获取或设置记账时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bookkeeping_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("bookkeeping_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset BookKeepingTIme { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置资金流水信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("funds_flow")]
        [System.Text.Json.Serialization.JsonPropertyName("funds_flow")]
        public Types.FundsFlow FundsFlow { get; set; } = default!;
    }
}
