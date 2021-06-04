using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/gettemplatedetail 接口的请求。</para>
    /// </summary>
    public class CgibinOAGetTemplateDetailRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置审批模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;
    }
}
