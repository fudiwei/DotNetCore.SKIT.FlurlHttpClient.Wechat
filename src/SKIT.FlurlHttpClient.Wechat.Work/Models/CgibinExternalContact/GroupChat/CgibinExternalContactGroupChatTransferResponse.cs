using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/transfer 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatTransferResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class GroupChat
            {
                /// <summary>
                /// 获取或设置客户群 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_id")]
                public string GroupChatId { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string ErrorMessage { get; set; } = default!;
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
