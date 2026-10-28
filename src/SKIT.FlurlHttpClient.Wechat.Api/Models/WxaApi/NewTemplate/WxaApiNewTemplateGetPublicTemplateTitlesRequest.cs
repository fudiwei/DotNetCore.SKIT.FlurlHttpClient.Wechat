namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/newtmpl/getpubtemplatetitles 接口的请求。</para>
    /// </summary>
    public class WxaApiNewTemplateGetPublicTemplateTitlesRequest : WechatApiRequest, IInferable<WxaApiNewTemplateGetPublicTemplateTitlesRequest, WxaApiNewTemplateGetPublicTemplateTitlesResponse>
    {
        /// <summary>
        /// 获取或设置类目 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public List<int>? CategoryIdList { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 10;
    }
}
