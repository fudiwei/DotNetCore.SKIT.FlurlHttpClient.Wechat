using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/appchat/update 接口的请求。</para>
    /// </summary>
    public class CgibinAppChatUpdateRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置群聊 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chatid")]
        [System.Text.Json.Serialization.JsonPropertyName("chatid")]
        public string ChatId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置群聊名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置群主 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner")]
        [System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? OwnerUserId { get; set; }

        /// <summary>
        /// 获取或设置添加的群成员 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("add_user_list")]
        public IList<string>? AddMemberUserIdList { get; set; }

        /// <summary>
        /// 获取或设置踢出的群成员 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("del_user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("del_user_list")]
        public IList<string>? RemoveMemberUserIdList { get; set; }
    }
}
