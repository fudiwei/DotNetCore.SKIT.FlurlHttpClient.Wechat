using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/enroll/query_by_tmp_openid 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingEnrollQueryByTempOpenIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置排序规则。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorting_rules")]
        [System.Text.Json.Serialization.JsonPropertyName("sorting_rules")]
        public int? SortingRule { get; set; }

        /// <summary>
        /// 获取或设置会议的成员临时 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tmp_openid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("tmp_openid_list")]
        public IList<string> TempOpenIdList { get; set; } = new List<string>();
    }
}
