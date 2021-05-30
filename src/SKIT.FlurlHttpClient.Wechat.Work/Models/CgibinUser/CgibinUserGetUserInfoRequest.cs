using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/user/getuserinfo 接口的请求。</para>
    /// </summary>
    public class CgibinUserGetUserInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置通过成员授权获取到的 Code。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Code { get; set; } = string.Empty;
    }
}
