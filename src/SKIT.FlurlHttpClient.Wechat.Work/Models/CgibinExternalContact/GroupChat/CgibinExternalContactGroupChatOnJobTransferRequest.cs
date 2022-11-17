using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/onjob_transfer 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatOnJobTransferRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置客户群 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_id_list")]
        public IList<string> GroupChatIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置新群主成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_owner")]
        [System.Text.Json.Serialization.JsonPropertyName("new_owner")]
        public string NewOwnerUserId { get; set; } = string.Empty;
    }
}
