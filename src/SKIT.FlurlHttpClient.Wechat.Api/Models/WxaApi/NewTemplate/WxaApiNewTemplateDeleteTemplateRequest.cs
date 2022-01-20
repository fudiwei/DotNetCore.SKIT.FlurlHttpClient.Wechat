namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/newtmpl/deltemplate 接口的请求。</para>
    /// </summary>
    public class WxaApiNewTemplateDeleteTemplateRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置要删除的模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priTmplId")]
        [System.Text.Json.Serialization.JsonPropertyName("priTmplId")]
        public string PrivateTemplateId { get; set; } = string.Empty;
    }
}
