using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/appchat/create 接口的请求。</para>
    /// </summary>
    public class CgibinAppChatCreateRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置群聊 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chatid")]
        [System.Text.Json.Serialization.JsonPropertyName("chatid")]
        public string? ChatId { get; set; }

        /// <summary>
        /// 获取或设置群聊名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置群主 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner")]
        [System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? OwnerUserId { get; set; }

        /// <summary>
        /// 获取或设置群成员 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userlist")]
        [System.Text.Json.Serialization.JsonPropertyName("userlist")]
        public IList<string> MemberUserIdList { get; set; } = new List<string>();
    }
}
