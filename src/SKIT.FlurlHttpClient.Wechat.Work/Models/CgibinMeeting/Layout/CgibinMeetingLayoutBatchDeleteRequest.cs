using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/advanced_layout/batch_delete 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingLayoutBatchDeleteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置布局 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("layout_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("layout_id_list")]
        public IList<string> LayoutIdList { get; set; } = new List<string>();
    }
}
