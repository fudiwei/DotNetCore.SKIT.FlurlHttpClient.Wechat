namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/pay_job_result 接口的响应。</para>
    /// </summary>
    public class CgibinLicensePayJobResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class JobResult
            {
                public static class Types
                {
                    public class FailedCorp
                    {
                        /// <summary>
                        /// 获取或设置企业 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("corpid")]
                        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                        public string CorpId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("errcode")]
                        [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                        public int ErrorCode { get; set; }

                        /// <summary>
                        /// 获取或设置错误码描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("errmsg")]
                        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                        public string? ErrorMessage { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误码描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }

                /// <summary>
                /// 获取或设置支付失败的企业列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_corp_list")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_corp_list")]
                public Types.FailedCorp[]? FailedCorpList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置支付任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int JobStatus { get; set; }

        /// <summary>
        /// 获取或设置支付任务结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_job_result")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_job_result")]
        public Types.JobResult JobResult { get; set; } = default!;
    }
}
