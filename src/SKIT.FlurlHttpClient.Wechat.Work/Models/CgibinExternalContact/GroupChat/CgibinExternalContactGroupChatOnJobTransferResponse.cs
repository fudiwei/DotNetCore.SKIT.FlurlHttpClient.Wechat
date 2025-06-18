namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/onjob_transfer 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatOnJobTransferResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class GroupChat : CgibinExternalContactGroupChatTransferResponse.Types.GroupChat
            {
            }
        }

        /// <summary>
        /// 获取或设置转交失败的客户群列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_chat_list")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_chat_list")]
        public Types.GroupChat[]? FailedGroupChatList { get; set; }
    }
}
