namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/favor/stocks/{stock_id}/pause 接口的响应。</para>
    /// </summary>
    public class PauseMarketingFavorStockResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string? StockId { get; set; }

        /// <summary>
        /// 获取或设置暂停时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pause_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pause_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset PauseTime { get; set; }
    }
}
