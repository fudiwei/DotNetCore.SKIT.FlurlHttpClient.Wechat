namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_order_list 接口的请求。</para>
    /// </summary>
    public class CgibinServiceGetOrderListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置终止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置测试模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("test_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("test_mode")]
        public int? TestMode { get; set; }
    }
}
