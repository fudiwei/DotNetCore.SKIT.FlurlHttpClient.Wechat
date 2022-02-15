namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/newtmpl/getpubtemplatekeywords 接口的请求。</para>
    /// </summary>
    public class WxaApiNewTemplateGetPublicTemplateKeywordsRequest : WechatApiRequest, IMapResponse<WxaApiNewTemplateGetPublicTemplateKeywordsRequest, WxaApiNewTemplateGetPublicTemplateKeywordsResponse>
    {
        /// <summary>
        /// 获取或设置模板标题 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string TemplateTitleId { get; set; } = string.Empty;
    }
}
