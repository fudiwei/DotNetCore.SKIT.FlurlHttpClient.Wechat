using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/ticket/getticket 接口的响应。</para>
    /// </summary>
    public class CgibinTicketGetTicketResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置 ApiTicket，即卡券接口中签名所需凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("ticket")]
        public string Ticket { get; set; } = default!;

        /// <summary>
        /// 获取或设置凭证有效时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
