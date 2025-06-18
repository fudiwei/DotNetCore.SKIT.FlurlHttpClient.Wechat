namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/charge/usage/get_recent_average 接口的响应。</para>
    /// </summary>
    public class WxaChargeUsageGetRecentAverageResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置最近月平均用量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("averageData")]
        [System.Text.Json.Serialization.JsonPropertyName("averageData")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long AverageData { get; set; }
    }
}
