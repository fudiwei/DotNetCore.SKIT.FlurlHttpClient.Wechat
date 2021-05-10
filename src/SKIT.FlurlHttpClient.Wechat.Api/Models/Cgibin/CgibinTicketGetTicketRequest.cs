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
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        public string Type { get; set; } = "jsapi";
    }
}
