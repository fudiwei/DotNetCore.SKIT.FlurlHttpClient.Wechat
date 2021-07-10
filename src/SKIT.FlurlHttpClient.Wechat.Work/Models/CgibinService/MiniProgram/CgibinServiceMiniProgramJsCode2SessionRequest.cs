using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/service/miniprogram/jscode2session 接口的请求。</para>
    /// </summary>
    public class CgibinServiceMiniProgramJsCode2SessionRequest : WechatWorkRequest
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
