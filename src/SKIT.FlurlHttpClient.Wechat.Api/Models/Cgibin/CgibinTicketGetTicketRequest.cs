using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/ticket/getticket 接口的请求。</para>
    /// </summary>
    public class CgibinTicketGetTicketRequest : WechatApiRequest
    {
        /// <summary>
        /// <para>获取或设置票据类型。</para>
        /// <para>默认值：jsapi</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Type { get; set; } = "jsapi";
    }
}
