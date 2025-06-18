namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/queryflow 接口的请求。</para>
    /// </summary>
    public class CgibinExpressIntracityQueryFlowRequest : WechatApiRequest, IInferable<CgibinExpressIntracityQueryFlowRequest, CgibinExpressIntracityQueryFlowResponse>
    {
        /// <summary>
        /// 获取或设置微信门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
        public string StoreId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置流水类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flow_type")]
        [System.Text.Json.Serialization.JsonPropertyName("flow_type")]
        public int FlowType { get; set; }

        /// <summary>
        /// 获取或设置运力 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_trans_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_trans_id")]
        public string? ServiceTransId { get; set; }

        /// <summary>
        /// 获取或设置开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long? BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }
    }
}
