using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /async_tasks/add 接口的响应。</para>
    /// </summary>
    public class AsyncTasksAddResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public int TaskId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
