using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_auth_info 接口的请求。</para>
    /// </summary>
    public class CgibinServiceGetAuthInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置授权方 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_corpid")]
        public string AuthorizerCorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置永久授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("permanent_code")]
        [System.Text.Json.Serialization.JsonPropertyName("permanent_code")]
        public string PermanentAuthCode { get; set; } = string.Empty;
    }
}
