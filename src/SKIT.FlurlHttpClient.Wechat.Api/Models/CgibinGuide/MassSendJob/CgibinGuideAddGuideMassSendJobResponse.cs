namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/addguidemassendjob 接口的响应。</para>
    /// </summary>
    public class CgibinGuideAddGuideMassSendJobResponse : WechatApiResponse
    {
        public static class Types
        {
            public class TaskResult
            {
                /// <summary>
                /// 获取或设置群发任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public long TaskId { get; set; }

                /// <summary>
                /// 获取或设置此任务包括的用户 OpenId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string[] OpenIdList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置群发任务结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_result")]
        [System.Text.Json.Serialization.JsonPropertyName("task_result")]
        public Types.TaskResult[] TaskResultList { get; set; } = default!;
    }
}
