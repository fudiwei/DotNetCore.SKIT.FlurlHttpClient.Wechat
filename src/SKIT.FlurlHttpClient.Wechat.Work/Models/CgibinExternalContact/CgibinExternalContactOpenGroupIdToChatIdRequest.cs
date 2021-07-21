using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/opengid_to_chatid 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactOpenGroupIdToChatIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置小程序在微信获取到的群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opengid")]
        [System.Text.Json.Serialization.JsonPropertyName("opengid")]
        public string OpenGroupId { get; set; } = string.Empty;
    }
}
