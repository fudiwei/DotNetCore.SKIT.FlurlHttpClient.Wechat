using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/menu/create 接口的请求。</para>
    /// </summary>
    public class CgibinMenuCreateRequest : WechatWorkRequest
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
                /// 获取或设置菜单名称。
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
        /// 获取或设置应用 ID。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.AgentId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置菜单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("button")]
        [System.Text.Json.Serialization.JsonPropertyName("button")]
        public IList<Types.Button> ButtonList { get; set; } = new List<Types.Button>();
    }
}
