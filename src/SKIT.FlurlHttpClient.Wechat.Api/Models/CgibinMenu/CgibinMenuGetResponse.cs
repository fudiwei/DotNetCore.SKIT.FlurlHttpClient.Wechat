using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/menu/get 接口的响应。</para>
    /// </summary>
    public class CgibinMenuGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Menu
            {
                public static class Types
                {
                    public class Button
                    {
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
                        /// 获取或设置网页链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// 获取或设置媒体文件标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string? MediaId { get; set; }

                        /// <summary>
                        /// 获取或设置图文消息的 ArticleId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("article_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("article_id")]
                        public string? ArticleId { get; set; }

                        /// <summary>
                        /// 获取或设置小程序的 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string? MiniProgramAppId { get; set; }

                        /// <summary>
                        /// 获取或设置小程序的页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pagepath")]
                        [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                        public string? MiniProgramPagePath { get; set; }

                        /// <summary>
                        /// 获取或设置子菜单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_button")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_button")]
                        public Button[]? SubButtonList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置菜单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("button")]
                [System.Text.Json.Serialization.JsonPropertyName("button")]
                public Types.Button[] ButtonList { get; set; } = default!;

                /// <summary>
                /// 获取或设置菜单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("menuid")]
                [System.Text.Json.Serialization.JsonPropertyName("menuid")]
                public int? MenuId { get; set; }
            }

            public class ConditionalMenu : Menu
            {
                public new static class Types
                {
                    public class MatchRule
                    {
                        /// <summary>
                        /// 获取或设置分组 ID（兼容旧的用户分组接口）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("group_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                        public int? GroupId { get; set; }

                        /// <summary>
                        /// 获取或设置标签 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
                        public int? TagId { get; set; }

                        /// <summary>
                        /// 获取或设置性别。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sex")]
                        [System.Text.Json.Serialization.JsonPropertyName("sex")]
                        public int? Sex { get; set; }

                        /// <summary>
                        /// 获取或设置客户端版本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("client_platform_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("client_platform_type")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? ClientPlatformType { get; set; }

                        /// <summary>
                        /// 获取或设置国家。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("country")]
                        [System.Text.Json.Serialization.JsonPropertyName("country")]
                        public string? Country { get; set; }

                        /// <summary>
                        /// 获取或设置省份。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province")]
                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                        public string? Province { get; set; }

                        /// <summary>
                        /// 获取或设置城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string? City { get; set; }

                        /// <summary>
                        /// 获取或设置语言。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("language")]
                        [System.Text.Json.Serialization.JsonPropertyName("language")]
                        public string? Language { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置菜单匹配规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("matchrule")]
                [System.Text.Json.Serialization.JsonPropertyName("matchrule")]
                public Types.MatchRule MatchRule { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置菜单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("menu")]
        [System.Text.Json.Serialization.JsonPropertyName("menu")]
        public Types.Menu Menu { get; set; } = default!;

        /// <summary>
        /// 获取或设置个性化菜单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conditionalmenu")]
        [System.Text.Json.Serialization.JsonPropertyName("conditionalmenu")]
        public Types.ConditionalMenu[]? ConditionalMenuList { get; set; }
    }
}
