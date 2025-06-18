namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/wxamptrade/get_penalty_list 接口的响应。</para>
    /// </summary>
    public class WxaApiWxaMpTradeGetPenaltyListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Appeal
            {
                /// <summary>
                /// 获取或设置扣分记录 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("illegalOrderId")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("illegalOrderId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long AppealId { get; set; }

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orderId")]
                [System.Text.Json.Serialization.JsonPropertyName("orderId")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置投诉单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaintOrderId")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("complaintOrderId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ComplaintOrderId { get; set; }

                /// <summary>
                /// 获取或设置违规行为。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("illegalWording")]
                [System.Text.Json.Serialization.JsonPropertyName("illegalWording")]
                public string IllegalWording { get; set; } = default!;

                /// <summary>
                /// 获取或设置扣分记录状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置扣除分数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("minusScore")]
                [System.Text.Json.Serialization.JsonPropertyName("minusScore")]
                public int MinusScore { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("illegalTime")]
                [System.Text.Json.Serialization.JsonPropertyName("illegalTime")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("updateTime")]
                [System.Text.Json.Serialization.JsonPropertyName("updateTime")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appealList")]
        [System.Text.Json.Serialization.JsonPropertyName("appealList")]
        public Types.Appeal[] AppealList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalNum")]
        [System.Text.Json.Serialization.JsonPropertyName("totalNum")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置交易体验分。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentScore")]
        [System.Text.Json.Serialization.JsonPropertyName("currentScore")]
        public int CurrentScore { get; set; }
    }
}
