namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/vip/submit_batch_del_job 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingVipSubmitBatchDeleteJobResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = default!;

        /// <summary>
        /// 获取或设置无效的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_userid_list")]
        public string[]? InvalidUserIdList { get; set; }
    }
}
