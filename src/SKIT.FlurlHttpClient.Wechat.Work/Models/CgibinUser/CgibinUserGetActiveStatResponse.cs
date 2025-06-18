namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/get_active_stat 接口的响应。</para>
    /// </summary>
    public class CgibinUserGetActiveStatResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置活跃成员数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("active_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("active_cnt")]
        public int ActiveUserCount { get; set; }
    }
}
