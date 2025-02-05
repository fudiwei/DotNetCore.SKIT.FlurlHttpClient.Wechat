using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.SpecialApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /spec/list_job 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-06-06 下线。")]
    public class SpecialListJobResponse : WechatWorkSpecialApiResponse
    {
        public static class Types
        {
            public class Job
            {
                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jobid")]
                [System.Text.Json.Serialization.JsonPropertyName("jobid")]
                public string JobId { get; set; } = default!;

                /// <summary>
                /// 获取或设置授权方 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_corpid")]
                public string AuthorizerCorpId { get; set; } = default!;

                /// <summary>
                /// 获取或设置自定义数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_data")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_data")]
                public string? CustomData { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置任务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("job_list")]
        [System.Text.Json.Serialization.JsonPropertyName("job_list")]
        public Types.Job[] JobList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }
    }
}
