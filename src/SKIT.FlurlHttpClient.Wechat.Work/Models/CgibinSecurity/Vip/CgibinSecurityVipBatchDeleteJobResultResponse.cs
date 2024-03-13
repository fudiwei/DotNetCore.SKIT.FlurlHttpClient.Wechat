namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/vip/batch_del_job_result 接口的响应。</para>
    /// </summary>
    public class CgibinSecurityVipBatchDeleteJobResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class JobResult
            {
                /// <summary>
                /// 获取或设置撤销分配成功的成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("succ_userid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("succ_userid_list")]
                public string[]? SuccessfulUserIdList { get; set; }

                /// <summary>
                /// 获取或设置撤销分配失败的成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_userid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_userid_list")]
                public string[]? FailedUserIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置任务结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job_result")]
        [System.Text.Json.Serialization.JsonPropertyName("job_result")]
        public Types.JobResult JobResult { get; set; } = default!;
    }
}
