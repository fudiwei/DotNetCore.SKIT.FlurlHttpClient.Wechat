using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/menu/trymatch 接口的响应。</para>
    /// </summary>
    public class CgibinMenuTryMatchResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Button : CgibinMenuGetResponse.Types.Menu.Types.Button
            { 
            }
        }

        /// <summary>
        /// 获取或设置匹配的菜单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("button")]
        [System.Text.Json.Serialization.JsonPropertyName("button")]
        public Types.Button[] ButtonList { get; set; } = default!;
    }
}
