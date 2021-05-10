using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /sns/jscode2session 接口的请求。</para>
    /// </summary>
    public class SnsJsCode2SessionRequest : WechatApiRequest
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        public string GrantType { get; set; } = "authorization_code";

        /// <summary>
        /// 获取或设置登录时获取的 Code。
        /// </summary>
        public string JsCode { get; set; } = string.Empty;
    }
}
