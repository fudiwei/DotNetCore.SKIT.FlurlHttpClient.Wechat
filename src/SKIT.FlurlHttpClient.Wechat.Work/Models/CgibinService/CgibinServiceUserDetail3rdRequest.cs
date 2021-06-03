using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/getuserdetail3rd 接口的请求。</para>
    /// </summary>
    public class CgibinServiceUserDetail3rdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("user_ticket")]
        public string UserTicket { get; set; } = string.Empty;
    }
}
