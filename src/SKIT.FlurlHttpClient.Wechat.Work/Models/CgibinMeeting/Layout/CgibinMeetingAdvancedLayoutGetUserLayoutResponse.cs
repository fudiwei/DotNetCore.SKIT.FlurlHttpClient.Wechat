namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/advanced_layout/get_user_layout 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingAdvancedLayoutGetUserLayoutResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Page : CgibinMeetingAdvancedLayoutListResponse.Types.Layout.Types.Page
            {
                public static new class Types
                {
                    public class PollingSettings : CgibinMeetingAdvancedLayoutListResponse.Types.Layout.Types.Page.Types.PollingSettings
                    {
                    }

                    public class UserSeat : CgibinMeetingAdvancedLayoutListResponse.Types.Layout.Types.Page.Types.UserSeat
                    {
                        public static new class Types
                        {
                            public class User : CgibinMeetingAdvancedLayoutListResponse.Types.Layout.Types.Page.Types.UserSeat.Types.User
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置用户列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                        public new Types.User[] UserList { get; set; } = default!;
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
                public new Types.UserSeat[] UserSeatList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置布局 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("selected_layout_id")]
        [System.Text.Json.Serialization.JsonPropertyName("selected_layout_id")]
        public string LayoutId { get; set; } = default!;

        /// <summary>
        /// 获取或设置布局名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("layout_name")]
        [System.Text.Json.Serialization.JsonPropertyName("layout_name")]
        public string LayoutName { get; set; } = default!;

        /// <summary>
        /// 获取或设置布局类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("layout_type")]
        [System.Text.Json.Serialization.JsonPropertyName("layout_type")]
        public int LayoutType { get; set; }

        /// <summary>
        /// 获取或设置布局单页列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_list")]
        [System.Text.Json.Serialization.JsonPropertyName("page_list")]
        public Types.Page[]? PageList { get; set; }
    }
}
