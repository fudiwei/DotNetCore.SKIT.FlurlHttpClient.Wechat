using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_moment_task 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGetMomentTaskRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置朋友圈 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("moment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("moment_id")]
        public string MomentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? NextCursor { get; set; }
    }
}
