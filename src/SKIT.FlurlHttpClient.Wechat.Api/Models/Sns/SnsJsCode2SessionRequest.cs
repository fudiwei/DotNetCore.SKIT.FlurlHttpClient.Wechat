using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /sns/jscode2session 接口的请求。</para>
    /// </summary>
    public class SnsJsCode2SessionRequest : WechatApiRequest, IMapResponse<SnsJsCode2SessionRequest, SnsJsCode2SessionResponse>
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string GrantType { get; set; } = "authorization_code";

        /// <summary>
        /// 获取或设置登录时获取的 Code。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string JsCode { get; set; } = string.Empty;
    }
}
