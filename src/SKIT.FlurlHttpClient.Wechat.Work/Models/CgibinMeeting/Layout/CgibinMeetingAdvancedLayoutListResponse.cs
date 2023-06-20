namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/advanced_layout/list 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingAdvancedLayoutListResponse : WechatWorkResponse
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
                            public class PollingSettings : CgibinMeetingAdvancedLayoutAddRequest.Types.Layout.Types.Page.Types.PollingSettings
                            {
                            }

                            public class UserSeat
                            {
                                public static class Types
                                {
                                    public class User : CgibinMeetingAdvancedLayoutAddRequest.Types.Layout.Types.Page.Types.UserSeat.Types.User
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置宫格 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("grid_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("grid_id")]
                                public string GridId { get; set; } = default!;

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
                                public int VideoType { get; set; }

                                /// <summary>
                                /// 获取或设置用户列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                                public Types.User[] UserList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置布局模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("layout_template_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("layout_template_id")]
                        public string LayoutTemplateId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否开启轮询。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enable_polling")]
                        [System.Text.Json.Serialization.JsonPropertyName("enable_polling")]
                        public bool EnablePolling { get; set; }

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
                        public Types.UserSeat[] UserSeatList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置布局 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("layout_id")]
                [System.Text.Json.Serialization.JsonPropertyName("layout_id")]
                public string LayoutId { get; set; } = default!;

                /// <summary>
                /// 获取或设置布局名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("layout_name")]
                [System.Text.Json.Serialization.JsonPropertyName("layout_name")]
                public string LayoutName { get; set; } = default!;

                /// <summary>
                /// 获取或设置布局单页列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_list")]
                [System.Text.Json.Serialization.JsonPropertyName("page_list")]
                public Types.Page[] PageList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置会议应用的布局 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("selected_layout_id")]
        [System.Text.Json.Serialization.JsonPropertyName("selected_layout_id")]
        public string SelectedLayoutId { get; set; } = default!;

        /// <summary>
        /// 获取或设置布局列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("layout_list")]
        [System.Text.Json.Serialization.JsonPropertyName("layout_list")]
        public Types.Layout[] LayoutList { get; set; } = default!;
    }
}
