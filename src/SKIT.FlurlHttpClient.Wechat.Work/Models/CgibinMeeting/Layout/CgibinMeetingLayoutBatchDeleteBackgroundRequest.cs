using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/layout/batch_delete_background 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingLayoutBatchDeleteBackgroundRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置背景 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("background_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("background_id_list")]
        public IList<string> BackgroundIdList { get; set; } = new List<string>();
    }
}
