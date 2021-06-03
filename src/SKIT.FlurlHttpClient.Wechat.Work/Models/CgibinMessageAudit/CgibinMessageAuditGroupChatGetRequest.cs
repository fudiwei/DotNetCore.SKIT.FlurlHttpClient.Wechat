using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/msgaudit/groupchat/get 接口的请求。</para>
    /// </summary>
    public class CgibinMessageAuditGroupChatGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置待查询的群聊房间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomid")]
        [System.Text.Json.Serialization.JsonPropertyName("roomid")]
        public string RoomId { get; set; } = string.Empty;
    }
}
