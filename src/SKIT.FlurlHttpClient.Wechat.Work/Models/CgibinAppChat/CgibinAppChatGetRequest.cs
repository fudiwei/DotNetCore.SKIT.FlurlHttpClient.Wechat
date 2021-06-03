using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/appchat/get 接口的请求。</para>
    /// </summary>
    public class CgibinAppChatGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置群聊 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ChatId { get; set; } = string.Empty;
    }
}
