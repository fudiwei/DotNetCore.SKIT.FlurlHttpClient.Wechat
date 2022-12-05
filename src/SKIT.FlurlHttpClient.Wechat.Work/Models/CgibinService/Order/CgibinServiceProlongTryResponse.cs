namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/prolong_try 接口的响应。</para>
    /// </summary>
    public class CgibinServiceProlongTryResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置试用到期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("try_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("try_end_time")]
        public long TryEndTimestamp { get; set; }
    }
}
