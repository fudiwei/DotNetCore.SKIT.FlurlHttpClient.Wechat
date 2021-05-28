using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/newtmpl/addtemplate 接口的响应。</para>
    /// </summary>
    public class WxaApiNewTemplateAddTemplateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置添加至帐号下的模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priTmplId")]
        [System.Text.Json.Serialization.JsonPropertyName("priTmplId")]
        public string PrivateTemplateId { get; set; } = default!;
    }
}
