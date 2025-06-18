using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/phone/get_tmp_openid 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingPhoneGetTempOpenIdRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Callout : CgibinMeetingPhoneCalloutRequest.Types.Callout
            {
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置外呼列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_numbers")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        public IList<Types.Callout> Calloutist { get; set; } = new List<Types.Callout>();
    }
}
