namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/unionid_to_external_userid 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGroupUnionidToExternalUserIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ExternalUser
            {
                /// <summary>
                /// 获取或设置企业 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                public string CorpId { get; set; } = default!;

                /// <summary>
                /// 获取或设置外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string ExternalUserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置外部联系人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid_info")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid_info")]
        public Types.ExternalUser[] ExternalUserList { get; set; } = default!;
    }
}
