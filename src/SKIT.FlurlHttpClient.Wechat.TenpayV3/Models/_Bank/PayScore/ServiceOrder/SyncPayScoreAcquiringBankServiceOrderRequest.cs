namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/acquiringbank/serviceorder/{out_order_no}/sync 接口的请求。</para>
    /// </summary>
    public class SyncPayScoreAcquiringBankServiceOrderRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Detail : SyncPayScoreServiceOrderRequest.Types.Detail
            {
            }
        }

        /// <summary>
        /// 获取或设置渠道商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户服务单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OutOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// 获取或设置场景类型。
        /// <para>默认值："Order_Paid"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; } = "Order_Paid";

        /// <summary>
        /// 获取或设置内容详情信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public Types.Detail? Detail { get; set; }
    }
}
