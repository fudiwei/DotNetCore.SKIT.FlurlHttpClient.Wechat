using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/layout/update 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingLayoutUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Page : CgibinMeetingLayoutAddRequest.Types.Layout.Types.Page
            {
                public static new class Types
                {
                    public class UserSeat : CgibinMeetingLayoutAddRequest.Types.Layout.Types.Page.Types.UserSeat
                    {
                    }
                }

                /// <summary>
                /// 获取或设置用户座次列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_seat_list")]
                [System.Text.Json.Serialization.JsonPropertyName("user_seat_list")]
                public new IList<Types.UserSeat> UserSeatList { get; set; } = new List<Types.UserSeat>();
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置布局 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("layout_id")]
        [System.Text.Json.Serialization.JsonPropertyName("layout_id")]
        public string LayoutId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置布局单页列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_list")]
        [System.Text.Json.Serialization.JsonPropertyName("page_list")]
        public IList<Types.Page> PageList { get; set; } = new List<Types.Page>();

        /// <summary>
        /// 获取或设置是否设置为会议应用的布局。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_set_default")]
        [System.Text.Json.Serialization.JsonPropertyName("enable_set_default")]
        public bool? EnableSetDefault { get; set; }
    }
}
