using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/batch/replaceparty 接口的请求。</para>
    /// </summary>
    public class CgibinBatchReplaceDepartmentRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Callback : CgibinBatchSyncUserRequest.Types.Callback
            {
            }
        }

        /// <summary>
        /// 获取或设置 CSV 文件 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback")]
        [System.Text.Json.Serialization.JsonPropertyName("callback")]
        public Types.Callback? Callback { get; set; }
    }
}
