namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_acquisition/customer 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactCustomerAcquisitionCustomerResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Customer
            {
                /// <summary>
                /// 获取或设置客户外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string ExternalUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置跟进人用户成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置会话状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_status")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_status")]
                public int ChatStatus { get; set; }

                /// <summary>
                /// 获取或设置自定义渠道参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public string? State { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置客户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer_list")]
        [System.Text.Json.Serialization.JsonPropertyName("customer_list")]
        public Types.Customer[] CustomerList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
