using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/menu/addconditional 接口的请求。</para>
    /// </summary>
    public class CgibinMenuAddConditionalRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Button : CgibinMenuCreateRequest.Types.Button
            { 
            }

            public class MatchRule
            {
                /// <summary>
                /// 获取或设置标签 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag_id")]
                [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
                public int? TagId { get; set; }

                /// <summary>
                /// 获取或设置客户端版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("client_platform_type")]
                [System.Text.Json.Serialization.JsonPropertyName("client_platform_type")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? ClientPlatformType { get; set; }

                /// <summary>
                /// 获取或设置语言。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("language")]
                [System.Text.Json.Serialization.JsonPropertyName("language")]
                public string? Language { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置菜单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("button")]
        [System.Text.Json.Serialization.JsonPropertyName("button")]
        public IList<Types.Button> ButtonList { get; set; } = new List<Types.Button>();

        /// <summary>
        /// 获取或设置菜单匹配规则。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matchrule")]
        [System.Text.Json.Serialization.JsonPropertyName("matchrule")]
        public Types.MatchRule MatchRule { get; set; } = new Types.MatchRule();
    }
}
