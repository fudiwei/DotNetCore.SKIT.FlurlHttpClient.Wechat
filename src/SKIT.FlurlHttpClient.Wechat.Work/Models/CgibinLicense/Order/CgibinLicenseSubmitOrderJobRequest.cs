namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/submit_order_job 接口的请求。</para>
    /// </summary>
    public class CgibinLicenseSubmitOrderJobRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class AccountDuration
            {
                /// <summary>
                /// 获取或设置购买的月数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("months")]
                [System.Text.Json.Serialization.JsonPropertyName("months")]
                public int? Months { get; set; }

                /// <summary>
                /// 获取或设置新的到期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("new_expire_time")]
                public long? NewExpireTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置下单人 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_userid")]
        public string BuyerUserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置账号购买时长信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("account_duration")]
        public Types.AccountDuration AccountDuration { get; set; } = new Types.AccountDuration();
    }
}
