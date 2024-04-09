namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/contact_list 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactContactListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ExternalContact
            {
                /// <summary>
                /// 获取或设置外部联系人 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string? ExternalUserId { get; set; }

                /// <summary>
                /// 获取或设置外部联系人临时 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmp_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("tmp_openid")]
                public string? TempOpenId { get; set; }

                /// <summary>
                /// 获取或设置外部联系人名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置添加此外部联系人的企业成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("follow_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("follow_userid")]
                public string? FollowUserId { get; set; }

                /// <summary>
                /// 获取或设置所在客户群的 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_id")]
                public string? GroupChatId { get; set; }

                /// <summary>
                /// 获取或设置所在客户群的群名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_name")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_name")]
                public string? GroupChatName { get; set; }

                /// <summary>
                /// 获取或设置添加时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("add_time")]
                [System.Text.Json.Serialization.JsonPropertyName("add_time")]
                public long AddTimestamp { get; set; }

                /// <summary>
                /// 获取或设置是否标记为客户。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_customer")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_customer")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsCustomer { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置外部联系人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("info_list")]
        public Types.ExternalContact[] ExternalContactList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
