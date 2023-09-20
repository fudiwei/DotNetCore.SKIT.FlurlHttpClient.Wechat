namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/preaddorder 接口的响应。</para>
    /// </summary>
    public class CgibinExpressIntracityPreAddOrderResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置运力 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_trans_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_trans_id")]
        public string ServiceTransId { get; set; } = default!;

        /// <summary>
        /// 获取或设置配送距离（单位：米）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distance")]
        [System.Text.Json.Serialization.JsonPropertyName("distance")]
        public int Distance { get; set; }

        /// <summary>
        /// 获取或设置预估配送费（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("est_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("est_fee")]
        public int EstimatedFee { get; set; }

        /// <summary>
        /// 获取或设置预计送达时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expected_finished_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expected_finished_time")]
        public long? ExpectedFinishedTimestamp { get; set; }

        /// <summary>
        /// 获取或设置预计配送时长（单位：分钟）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promise_delivery_time")]
        [System.Text.Json.Serialization.JsonPropertyName("promise_delivery_time")]
        public long? PromiseDeliveryTime { get; set; }
    }
}
