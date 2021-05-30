using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/user/delete 接口的请求。</para>
    /// </summary>
    public class CgibinUserDeleteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置用户账号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string UserId { get; set; } = string.Empty;
    }
}
