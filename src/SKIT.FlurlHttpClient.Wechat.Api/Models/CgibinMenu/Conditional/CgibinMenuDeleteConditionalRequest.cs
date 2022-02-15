using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/menu/delconditional 接口的请求。</para>
    /// </summary>
    public class CgibinMenuDeleteConditionalRequest : WechatApiRequest, IMapResponse<CgibinMenuDeleteConditionalRequest, CgibinMenuDeleteConditionalResponse>
    {
        /// <summary>
        /// 获取或设置菜单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("menuid")]
        [System.Text.Json.Serialization.JsonPropertyName("menuid")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int MenuId { get; set; }
    }
}
