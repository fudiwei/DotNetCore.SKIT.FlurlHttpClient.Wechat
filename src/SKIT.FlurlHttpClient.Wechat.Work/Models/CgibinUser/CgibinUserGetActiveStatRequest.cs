namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/get_active_stat 接口的请求。</para>
    /// </summary>
    public class CgibinUserGetActiveStatRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置查询日期（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public string DateString { get; set; } = string.Empty;
    }
}
