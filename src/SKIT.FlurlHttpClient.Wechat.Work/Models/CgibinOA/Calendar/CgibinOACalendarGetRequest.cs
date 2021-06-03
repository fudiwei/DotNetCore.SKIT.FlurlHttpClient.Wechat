using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/calendar/get 接口的请求。</para>
    /// </summary>
    public class CgibinOACalendarGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置日历 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cal_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("cal_id_list")]
        public IList<string> CalendarIdList { get; set; } = new List<string>();
    }
}
