using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/modify_wxa_jump_domain 接口的请求。</para>
    /// </summary>
    public class CgibinComponentModifyWxaJumpDomainRequest : WechatApiRequest, IMapResponse<CgibinComponentModifyWxaJumpDomainRequest, CgibinComponentModifyWxaJumpDomainResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否同时修改全网发布版本的值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_modify_published_together")]
        [System.Text.Json.Serialization.JsonPropertyName("is_modify_published_together")]
        public bool? IsModifyPublishedTogether { get; set; }

        /// <summary>
        /// 获取或设置业务域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_jump_h5_domain")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringIListWithSemicolonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_jump_h5_domain")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringIListWithSemicolonConverter))]
        public IList<string>? WxaJumpH5DomainList { get; set; }
    }
}
