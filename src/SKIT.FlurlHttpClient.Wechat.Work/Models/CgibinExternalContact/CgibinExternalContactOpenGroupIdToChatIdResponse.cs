namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/opengid_to_chatid 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactOpenGroupIdToChatIdResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置客户群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string GroupChatId { get; set; } = default!;
    }
}
