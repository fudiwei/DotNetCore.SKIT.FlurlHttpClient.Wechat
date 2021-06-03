using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/schedule/add 接口的响应。</para>
    /// </summary>
    public class CgibinOAScheduleAddResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置日程 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
        public string ScheduleId { get; set; } = default!;
    }
}
