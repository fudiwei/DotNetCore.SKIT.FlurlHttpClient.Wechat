using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/approval/update_template 接口的请求。</para>
    /// </summary>
    public class CgibinOAApprovalUpdateTemplateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class MultiLangText : CgibinOAApprovalCreateTemplateRequest.Types.MultiLangText
            {
            }

            public class TemplateContent : CgibinOAApprovalCreateTemplateRequest.Types.TemplateContent
            {
            }
        }

        /// <summary>
        /// 获取或设置模版 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板名称列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_name")]
        [System.Text.Json.Serialization.JsonPropertyName("template_name")]
        public IList<Types.MultiLangText> TemplateName { get; set; } = new List<Types.MultiLangText>();

        /// <summary>
        /// 获取或设置模板内容信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_content")]
        [System.Text.Json.Serialization.JsonPropertyName("template_content")]
        public Types.TemplateContent TemplateContent { get; set; } = new Types.TemplateContent();
    }
}
