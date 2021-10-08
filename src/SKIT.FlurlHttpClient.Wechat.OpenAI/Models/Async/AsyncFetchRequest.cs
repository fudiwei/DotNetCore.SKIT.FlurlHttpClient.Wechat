using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/async/fetch 接口的请求。</para>
    /// </summary>
    public class AsyncFetchRequest : WechatOpenAIRequest
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string TaskId { get; set; } = string.Empty;
    }
}
