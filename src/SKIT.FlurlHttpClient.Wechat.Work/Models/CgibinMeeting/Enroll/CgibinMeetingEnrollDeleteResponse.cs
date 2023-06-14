namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/enroll/delete 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingEnrollDeleteResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置成功删除的报名信息条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
