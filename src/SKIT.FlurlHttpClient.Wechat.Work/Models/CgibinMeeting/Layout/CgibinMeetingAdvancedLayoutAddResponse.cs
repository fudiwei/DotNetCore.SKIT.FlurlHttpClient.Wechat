namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/advanced_layout/add 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingAdvancedLayoutAddResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Layout : CgibinMeetingAdvancedLayoutListResponse.Types.__zz__Layout
            {
                public static class Types
                {
                    public class Page : CgibinMeetingAdvancedLayoutListResponse.Types.Layout.Types.__zz__Page
                    {
                        public static class Types
                        {
                            public class PollingSettings : CgibinMeetingAdvancedLayoutListResponse.Types.Layout.Types.Page.Types.PollingSettings
                            {
                            }

                            public class UserSeat : CgibinMeetingAdvancedLayoutListResponse.Types.Layout.Types.Page.Types.__zz__UserSeat
                            {
                                public static class Types
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
                                public List<Types.User>? UserList { get; set; }
                            }
                        }

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
                        public List<Types.UserSeat>? UserSeatList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置布局单页列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_list")]
                [System.Text.Json.Serialization.JsonPropertyName("page_list")]
                public List<Types.Page>? PageList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置布局列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("layout_list")]
        [System.Text.Json.Serialization.JsonPropertyName("layout_list")]
        public List<Types.Layout>? LayoutList { get; set; }
    }
}
