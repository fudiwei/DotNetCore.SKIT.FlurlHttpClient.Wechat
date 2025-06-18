namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/layout/add 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingLayoutAddResponse : WechatWorkResponse
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
                            public class UserSeat
                            {
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

                                /// <summary>
                                /// 获取或设置拓展应用 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tool_sdkid")]
                                [System.Text.Json.Serialization.JsonPropertyName("tool_sdkid")]
                                public string? ToolSdkId { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置布局模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("layout_template_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("layout_template_id")]
                        public string LayoutTemplateId { get; set; } = default!;

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
