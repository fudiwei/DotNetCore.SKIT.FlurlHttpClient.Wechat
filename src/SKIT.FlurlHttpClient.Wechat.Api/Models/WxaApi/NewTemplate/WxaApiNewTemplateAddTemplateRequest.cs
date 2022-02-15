using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/newtmpl/addtemplate 接口的请求。</para>
    /// </summary>
    public class WxaApiNewTemplateAddTemplateRequest : WechatApiRequest, IMapResponse<WxaApiNewTemplateAddTemplateRequest, WxaApiNewTemplateAddTemplateResponse>
    {
        /// <summary>
        /// 获取或设置模板标题 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tid")]
        [System.Text.Json.Serialization.JsonPropertyName("tid")]
        public string TemplateTitleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板关键词 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kidList")]
        [System.Text.Json.Serialization.JsonPropertyName("kidList")]
        public IList<int> KeyworkIdList { get; set; } = new List<int>();

        /// <summary>
        /// 获取或设置服务场景描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sceneDesc")]
        [System.Text.Json.Serialization.JsonPropertyName("sceneDesc")]
        public string SceneDescription { get; set; } = string.Empty;
    }
}
