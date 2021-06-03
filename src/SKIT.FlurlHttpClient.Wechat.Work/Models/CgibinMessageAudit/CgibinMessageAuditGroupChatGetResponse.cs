using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/msgaudit/groupchat/get 接口的响应。</para>
    /// </summary>
    public class CgibinMessageAuditGroupChatGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Member
            {
                /// <summary>
                /// 获取或设置群成员的 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("memberid")]
                [System.Text.Json.Serialization.JsonPropertyName("memberid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置入群时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jointime")]
                [System.Text.Json.Serialization.JsonPropertyName("jointime")]
                public long JoinTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置群聊房间名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomname")]
        [System.Text.Json.Serialization.JsonPropertyName("roomname")]
        public string RoomName { get; set; } = default!;

        /// <summary>
        /// 获取或设置群聊创建者的成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator")]
        [System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string CreatorUserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置群成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("members")]
        [System.Text.Json.Serialization.JsonPropertyName("members")]
        public Types.Member[] MemberList { get; set; } = default!;

        /// <summary>
        /// 获取或设置群公告。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notice")]
        [System.Text.Json.Serialization.JsonPropertyName("notice")]
        public string Notice { get; set; } = default!;

        /// <summary>
        /// 获取或设置群聊创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("room_create_time")]
        public long CreateTimestamp { get; set; }
    }
}
