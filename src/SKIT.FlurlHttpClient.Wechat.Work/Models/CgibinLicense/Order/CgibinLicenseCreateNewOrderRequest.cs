namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/create_new_order 接口的请求。</para>
    /// </summary>
    public class CgibinLicenseCreateNewOrderRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class AccountCount
            {
                /// <summary>
                /// 获取或设置基础帐号个数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_count")]
                [System.Text.Json.Serialization.JsonPropertyName("base_count")]
                public int? BaseCount { get; set; }

                /// <summary>
                /// 获取或设置互通帐号个数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_contact_count")]
                [System.Text.Json.Serialization.JsonPropertyName("external_contact_count")]
                public int? ExternalContactCount { get; set; }
            }

            public class AccountDuration
            {
                /// <summary>
                /// 获取或设置购买的月数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("months")]
                [System.Text.Json.Serialization.JsonPropertyName("months")]
                public int? Months { get; set; }

                /// <summary>
                /// 获取或设置购买的天数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("days")]
                [System.Text.Json.Serialization.JsonPropertyName("days")]
                public int? Days { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string CorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置下单人成员 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_userid")]
        public string BuyerUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置账号个数信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_count")]
        [System.Text.Json.Serialization.JsonPropertyName("account_count")]
        public Types.AccountCount AccountCount { get; set; } = new Types.AccountCount();

        /// <summary>
        /// 获取或设置账号时长信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("account_duration")]
        public Types.AccountDuration AccountDuration { get; set; } = new Types.AccountDuration();
    }
}
