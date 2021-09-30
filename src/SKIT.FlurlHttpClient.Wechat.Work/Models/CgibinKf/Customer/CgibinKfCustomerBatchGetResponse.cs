namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/customer/batchget 接口的响应。</para>
    /// </summary>
    public class CgibinKfCustomerBatchGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Customer
            {
                /// <summary>
                /// 获取或设置外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string ExternalUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                public string AvatarUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置性别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gender")]
                [System.Text.Json.Serialization.JsonPropertyName("gender")]
                public int Gender { get; set; }

                /// <summary>
                /// 获取或设置用户 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unionid")]
                [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                public string? UnionId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置客户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer_list")]
        [System.Text.Json.Serialization.JsonPropertyName("customer_list")]
        public Types.Customer[] CustomerLsit { get; set; } = default!;

        /// <summary>
        /// 获取或设置无效的外部联系人账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_external_userid")]
        public string[] InvalidExternalUserIdList { get; set; } = default!;
    }
}
