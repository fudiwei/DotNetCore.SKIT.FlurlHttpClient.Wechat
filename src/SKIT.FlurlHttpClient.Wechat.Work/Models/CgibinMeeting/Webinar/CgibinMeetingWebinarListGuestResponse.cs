namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/list_guest 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingWebinarListGuestResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Guest : CgibinMeetingWebinarUpdateGuestListRequest.Types.Guest
            {
            }
        }

        /// <summary>
        /// 获取或设置嘉宾列表。。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guests")]
        [System.Text.Json.Serialization.JsonPropertyName("guests")]
        public Types.Guest[] GuestList { get; set; } = default!;
    }
}
