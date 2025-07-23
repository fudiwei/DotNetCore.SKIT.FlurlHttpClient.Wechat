using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/groupchat/update 接口的请求。</para>
    /// </summary>
    public class CgibinWedocSmartSheetGroupChatUpdateRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置群聊 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string GroupChatId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置新的群主成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner")]
        [System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? OwnerUserId { get; set; }

        /// <summary>
        /// 获取或设置添加的群成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("add_user_list")]
        public IList<string>? AddedUserIdList { get; set; }

        /// <summary>
        /// 获取或设置移除的群成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("del_user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("del_user_list")]
        public IList<string>? DeletedUserIdList { get; set; }
    }
}
