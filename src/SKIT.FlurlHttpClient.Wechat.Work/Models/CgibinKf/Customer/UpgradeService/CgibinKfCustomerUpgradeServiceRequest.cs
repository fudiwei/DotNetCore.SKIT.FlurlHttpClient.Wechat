namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/customer/upgrade_service 接口的请求。</para>
    /// </summary>
    public class CgibinKfCustomerUpgradeServiceRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Member
            {
                /// <summary>
                /// 获取或设置服务专员的 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置推荐语。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wording")]
                [System.Text.Json.Serialization.JsonPropertyName("wording")]
                public string? Wording { get; set; }
            }

            public class GroupChat
            {
                /// <summary>
                /// 获取或设置客户群 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_id")]
                public string GroupChatId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置推荐语。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wording")]
                [System.Text.Json.Serialization.JsonPropertyName("wording")]
                public string? Wording { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置客服账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_kfid")]
        [System.Text.Json.Serialization.JsonPropertyName("open_kfid")]
        public string OpenKfId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置外部联系人账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public string ExternalUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置升级服务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置专员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("member")]
        [System.Text.Json.Serialization.JsonPropertyName("member")]
        public Types.Member? Member { get; set; }

        /// <summary>
        /// 获取或设置客户群信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupchat")]
        [System.Text.Json.Serialization.JsonPropertyName("groupchat")]
        public Types.GroupChat? GroupChat { get; set; }
    }
}
