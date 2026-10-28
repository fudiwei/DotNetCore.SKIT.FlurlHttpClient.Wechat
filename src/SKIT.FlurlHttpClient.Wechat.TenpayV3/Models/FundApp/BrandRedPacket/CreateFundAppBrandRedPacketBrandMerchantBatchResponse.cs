namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /fund-app/brand-redpacket/brand-merchant-batches 接口的响应。</para>
    /// </summary>
    public class CreateFundAppBrandRedPacketBrandMerchantBatchResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置商家批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_no")]
        public string? OutBatchNumber { get; set; }

        /// <summary>
        /// 获取或设置微信批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_no")]
        public string? BatchNumber { get; set; }

        /// <summary>
        /// 获取或设置批次状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_state")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_state")]
        public string? BatchState { get; set; }

        /// <summary>
        /// 获取或设置批次创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }
    }
}
