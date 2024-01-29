namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/get_current_selfmenu_info 接口的响应。</para>
    /// </summary>
    public class CgibinGetCurrentSelfMenuInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Menu
            {
                public static class Types
                {
                    public class Button
                    {
                        public static class Types
                        {
                            public class NewsList
                            {
                                /// <summary>
                                /// 获取或设置图文消息列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("list")]
                                [System.Text.Json.Serialization.JsonPropertyName("list")]
                                public NewsItem[] List { get; set; } = default!;
                            }

                            public class NewsItem
                            {
                                /// <summary>
                                /// 获取或设置图文消息标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图文消息摘要。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("author")]
                                [System.Text.Json.Serialization.JsonPropertyName("author")]
                                public string? Author { get; set; }

                                /// <summary>
                                /// 获取或设置图文消息摘要。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("digest")]
                                [System.Text.Json.Serialization.JsonPropertyName("digest")]
                                public string? Digest { get; set; }

                                /// <summary>
                                /// 获取或设置是否显示封面。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("show_cover")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("show_cover")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                                public bool IsShowCover { get; set; }

                                /// <summary>
                                /// 获取或设置封面图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cover_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("cover_url")]
                                public string CoverUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置正文 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("content_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("content_url")]
                                public string ContentUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置原文 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("source_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("source_url")]
                                public string? SourceUrl { get; set; }
                            }

                            public class SubButton
                            {
                                /// <summary>
                                /// 获取或设置子菜单列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("list")]
                                [System.Text.Json.Serialization.JsonPropertyName("list")]
                                public Button[]? List { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置菜单的响应动作类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置菜单标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置菜单 KEY 值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string? Key { get; set; }

                        /// <summary>
                        /// 获取或设置菜单 VALUE 值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string? Value { get; set; }

                        /// <summary>
                        /// 获取或设置网页链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// 获取或设置图文消息信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("news_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("news_info")]
                        public Types.NewsList? News { get; set; }

                        /// <summary>
                        /// 获取或设置子菜单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_button")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_button")]
                        public Types.SubButton? SubButton { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置菜单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("button")]
                [System.Text.Json.Serialization.JsonPropertyName("button")]
                public Types.Button[] ButtonList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置菜单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_menu_open")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_menu_open")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsMenuOpen { get; set; }

        /// <summary>
        /// 获取或设置菜单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("selfmenu_info")]
        [System.Text.Json.Serialization.JsonPropertyName("selfmenu_info")]
        public Types.Menu SelfMenu { get; set; } = default!;
    }
}
