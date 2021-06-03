using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/getuserid 接口的请求。</para>
    /// </summary>
    public class CgibinUserGetUserIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        public string MobileNumber { get; set; } = string.Empty;
    }
}
