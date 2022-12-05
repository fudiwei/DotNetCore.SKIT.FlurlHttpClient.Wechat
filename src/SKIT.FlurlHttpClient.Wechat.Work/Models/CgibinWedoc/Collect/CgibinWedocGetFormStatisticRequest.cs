namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/get_form_statistic 接口的请求。</para>
    /// </summary>
    public class CgibinWedocGetFormStatisticRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置收集表周期 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repeated_id")]
        [System.Text.Json.Serialization.JsonPropertyName("repeated_id")]
        public string RepeatedId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置请求类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req_type")]
        [System.Text.Json.Serialization.JsonPropertyName("req_type")]
        public int RequestType { get; set; }

        /// <summary>
        /// 获取或设置开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public int? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public int? Endimestamp { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public int? Cursor { get; set; }
    }
}
