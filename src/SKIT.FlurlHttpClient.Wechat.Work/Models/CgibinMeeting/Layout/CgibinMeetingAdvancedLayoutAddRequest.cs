using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/advanced_layout/add 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingAdvancedLayoutAddRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Layout
            {
                public static class Types
                {
                    public class Page
                    {
                        public static class Types
                        {
                            public class PollingSettings
                            {
                                /// <summary>
                                /// 获取或设置轮询间隔时间类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("polling_interval_unit")]
                                [System.Text.Json.Serialization.JsonPropertyName("polling_interval_unit")]
                                public int PollingIntervalUnitType { get; set; }

                                /// <summary>
                                /// 获取或设置轮询间隔时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("polling_interval")]
                                [System.Text.Json.Serialization.JsonPropertyName("polling_interval")]
                                public int PollingInterval { get; set; }

                                /// <summary>
                                /// 获取或设置是否忽略没开启视频成员。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ignore_user_novideo")]
                                [System.Text.Json.Serialization.JsonPropertyName("ignore_user_novideo")]
                                public bool IsIgnoreUserNoVideo { get; set; }

                                /// <summary>
                                /// 获取或设置设置是否忽略未入会成员。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ignore_user_absence")]
                                [System.Text.Json.Serialization.JsonPropertyName("ignore_user_absence")]
                                public bool IsIgnoreUserAbsence { get; set; }
                            }

                            public class UserSeat
                            {
                                public static class Types
                                {
                                    public class User
                                    {
                                        /// <summary>
                                        /// 获取或设置参会的成员账号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("userid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                                        public string? UserId { get; set; }

                                        /// <summary>
                                        /// 获取或设置参会的成员临时 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("tmp_openid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("tmp_openid")]
                                        public string? TempOpenId { get; set; }

                                        /// <summary>
                                        /// 获取或设置昵称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("nick_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                                        public string? Nickname { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置宫格 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("grid_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("grid_id")]
                                public string GridId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置宫格类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("grid_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("grid_type")]
                                public int GridType { get; set; }

                                /// <summary>
                                /// 获取或设置视频画面来源。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("video_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("video_type")]
                                public int? VideoType { get; set; }

                                /// <summary>
                                /// 获取或设置用户列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                                public IList<Types.User>? UserList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置布局模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("layout_template_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("layout_template_id")]
                        public string LayoutTemplateId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置是否开启轮询。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enable_polling")]
                        [System.Text.Json.Serialization.JsonPropertyName("enable_polling")]
                        public bool? EnablePolling { get; set; }

                        /// <summary>
                        /// 获取或设置轮询配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("polling_setting")]
                        [System.Text.Json.Serialization.JsonPropertyName("polling_setting")]
                        public Types.PollingSettings? PollingSettings { get; set; }

                        /// <summary>
                        /// 获取或设置用户座次列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_seat_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_seat_list")]
                        public IList<Types.UserSeat> UserSeatList { get; set; } = new List<Types.UserSeat>();
                    }
                }

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

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置布局列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("layout_list")]
        [System.Text.Json.Serialization.JsonPropertyName("layout_list")]
        public IList<Types.Layout> LayoutList { get; set; } = new List<Types.Layout>();
    }
}
