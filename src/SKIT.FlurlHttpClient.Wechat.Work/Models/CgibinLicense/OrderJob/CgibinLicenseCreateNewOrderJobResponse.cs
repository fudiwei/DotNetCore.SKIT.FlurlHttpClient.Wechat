namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/create_new_order_job 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseCreateNewOrderJobResponse : WechatWorkResponse
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
                /// 获取或设置错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string ErrorMessage { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置多企业新购任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string? JobId { get; set; }

        /// <summary>
        /// 获取或设置失败企业列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_list")]
        public Types.FailedCorp[]? FailedCorpList { get; set; }
    }
}
