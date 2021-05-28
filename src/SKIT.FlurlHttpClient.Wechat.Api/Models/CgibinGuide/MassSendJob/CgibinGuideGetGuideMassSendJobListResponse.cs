using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidemassendjoblist 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideMassSendJobListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Job : CgibinGuideGetGuideMassSendJobResponse.Types.Job
            {
            }
        }

        /// <summary>
        /// 获取或设置任务总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int Total { get; set; }

        /// <summary>
        /// 获取或设置群发任务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Job[] JobList { get; set; } = default!;
    }
}
