using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/schedule/get 接口的请求。</para>
    /// </summary>
    public class CgibinOAScheduleGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置日程 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_id_list")]
        public IList<string> ScheduleIdList { get; set; } = new List<string>();
    }
}
