namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_acquisition/get_chat_info 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactCustomerAcquisitionGetChatInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Chat
            {
                /// <summary>
                /// 获取或设置添加客户的获客链接 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link_id")]
                [System.Text.Json.Serialization.JsonPropertyName("link_id")]
                public string LinkId { get; set; } = default!;

                /// <summary>
                /// 获取或设置添加客户的自定义参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public string? State { get; set; }

                /// <summary>
                /// 获取或设置收到的消息次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recv_msg_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("recv_msg_cnt")]
                public int ReceivedMessageCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置成员 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置外部成员 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public string ExternalUserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置多次会话信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_info")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_info")]
        public Types.Chat Chat { get; set; } = default!;
    }
}
