namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/batch/get_by_user 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactBatchGetByUserResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ExternalContactUser
            {
                public static class Types
                {
                    public class ExternalContact : CgibinExternalContactGetResponse.Types.ExternalContact
                    {
                    }

                    public class FollowUser : CgibinExternalContactGetResponse.Types.FollowUser
                    {
                    }
                }

                /// <summary>
                /// 获取或设置外部联系人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_contact")]
                [System.Text.Json.Serialization.JsonPropertyName("external_contact")]
                public Types.ExternalContact ExternalContact { get; set; } = default!;

                /// <summary>
                /// 获取或设置添加了此外部联系人的企业成员信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("follow_info")]
                [System.Text.Json.Serialization.JsonPropertyName("follow_info")]
                public Types.FollowUser FollowUser { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置外部联系人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_contact_list")]
        [System.Text.Json.Serialization.JsonPropertyName("external_contact_list")]
        public Types.ExternalContactUser[] ExternalContactList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
