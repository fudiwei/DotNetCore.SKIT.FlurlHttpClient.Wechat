using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/membercard/activatetempinfo/get 接口的请求。</para>
    /// </summary>
    public class CardMemberCardActivateTempInfoGetRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置跳转型开卡组件开卡后回调中的激活票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activate_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("activate_ticket")]
        public string ActivateTicket { get; set; } = string.Empty;
    }
}
