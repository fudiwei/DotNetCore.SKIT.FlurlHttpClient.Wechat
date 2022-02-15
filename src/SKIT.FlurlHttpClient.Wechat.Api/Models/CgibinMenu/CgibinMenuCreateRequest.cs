using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/menu/create 接口的请求。</para>
    /// </summary>
    public class CgibinMenuCreateRequest : WechatApiRequest, IMapResponse<CgibinMenuCreateRequest, CgibinMenuCreateResponse>
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
                public string Type { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置菜单标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

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
                public IList<Button>? SubButtonList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置菜单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("button")]
        [System.Text.Json.Serialization.JsonPropertyName("button")]
        public IList<Types.Button> ButtonList { get; set; } = new List<Types.Button>();
    }
}
