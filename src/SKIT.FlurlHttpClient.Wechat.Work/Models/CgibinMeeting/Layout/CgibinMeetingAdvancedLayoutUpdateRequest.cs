using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/advanced_layout/update 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingAdvancedLayoutUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Page : CgibinMeetingAdvancedLayoutAddRequest.Types.Layout.Types.Page
            {
                public static new class Types
                {
                    public class PollingSettings : CgibinMeetingAdvancedLayoutAddRequest.Types.Layout.Types.Page.Types.PollingSettings
                    {
                    }

                    public class UserSeat : CgibinMeetingAdvancedLayoutAddRequest.Types.Layout.Types.Page.Types.UserSeat
                    {
                        public static new class Types
                        {
                            public class User : CgibinMeetingAdvancedLayoutAddRequest.Types.Layout.Types.Page.Types.UserSeat.Types.User
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置用户列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                        public new IList<Types.User>? UserList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置轮询配置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("polling_setting")]
                [System.Text.Json.Serialization.JsonPropertyName("polling_setting")]
                public new Types.PollingSettings? PollingSettings { get; set; }

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
        /// 获取或设置布局名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("layout_name")]
        [System.Text.Json.Serialization.JsonPropertyName("layout_name")]
        public string? LayoutName { get; set; }

        /// <summary>
        /// 获取或设置布局单页列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_list")]
        [System.Text.Json.Serialization.JsonPropertyName("page_list")]
        public IList<Types.Page> PageList { get; set; } = new List<Types.Page>();
    }
}
