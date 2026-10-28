namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/get_new_external_userid 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatGetNewExternalUserIdRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置客户群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? GroupChatId { get; set; }

        /// <summary>
        /// 获取或设置原外部联系人账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid_list")]
        public List<string>? ExternalUserIdList { get; set; }
    }
}
