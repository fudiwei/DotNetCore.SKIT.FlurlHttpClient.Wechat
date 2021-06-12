using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /async_task_files/get 接口的请求。</para>
    /// </summary>
    public class AsyncTaskFilesGetRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int TaskId { get; set; }

        /// <summary>
        /// 获取或设置任务文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int FileId { get; set; }
    }
}
