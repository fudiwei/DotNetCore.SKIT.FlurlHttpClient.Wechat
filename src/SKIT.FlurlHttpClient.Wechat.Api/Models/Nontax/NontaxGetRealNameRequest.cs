using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/getrealname 接口的请求。</para>
    /// </summary>
    public class NontaxGetRealNameRequest : WechatApiRequest, IMapResponse<NontaxGetRealNameRequest, NontaxGetRealNameResponse>
    {
        /// <summary>
        /// 获取或设置微信实名信息 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_realname_token")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_realname_token")]
        public string WechatRealNameToken { get; set; } = string.Empty;
    }
}
