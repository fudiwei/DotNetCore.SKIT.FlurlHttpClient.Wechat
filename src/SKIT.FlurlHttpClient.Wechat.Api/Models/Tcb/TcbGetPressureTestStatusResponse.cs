using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getpressureteststatus 接口的响应。</para>
    /// </summary>
    public class TcbGetPressureTestStatusResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置压测任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置压测开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beg_time")]
        [System.Text.Json.Serialization.JsonPropertyName("beg_time")]
        public long? BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置压测结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }
    }
}
