using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-risk-manage/ec-trade-risk/query-risk-trades 接口的响应。</para>
    /// </summary>
    public class QueryMerchantRiskManageECTradeRiskTradesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class RiskTrade
            {
                /// <summary>
                /// 获取或设置微信商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                public string OutTradeNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置风险类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("risk_type")]
                [System.Text.Json.Serialization.JsonPropertyName("risk_type")]
                public int RiskType { get; set; }

                /// <summary>
                /// 获取或设置风险等级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("risk_level")]
                [System.Text.Json.Serialization.JsonPropertyName("risk_level")]
                public int RiskLevel { get; set; }

                /// <summary>
                /// 获取或设置风险发现时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("risk_discove_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("risk_discove_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset RiskDiscoveTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置风险订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_trade_list")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_trade_list")]
        public Types.RiskTrade[] RiskTradeList { get; set; } = default!;
    }
}
