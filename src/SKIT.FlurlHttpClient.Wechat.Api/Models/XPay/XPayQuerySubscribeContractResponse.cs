namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_subscribe_contract 接口的响应。</para>
    /// </summary>
    public class XPayQuerySubscribeContractResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AppleSubscriptionInfo
            {
                /// <summary>
                /// 获取或设置苹果原始交易 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_transaction_id")]
                [System.Text.Json.Serialization.JsonPropertyName("original_transaction_id")]
                public string OriginalTransactionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置自动续费状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auto_renew_status")]
                [System.Text.Json.Serialization.JsonPropertyName("auto_renew_status")]
                public int AutoRenewStatus { get; set; }

                /// <summary>
                /// 获取或设置订阅最早起始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recent_subscription_start_date")]
                [System.Text.Json.Serialization.JsonPropertyName("recent_subscription_start_date")]
                public long RecentSubscriptionStartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置订阅下次续费时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("renewal_date")]
                [System.Text.Json.Serialization.JsonPropertyName("renewal_date")]
                public long RenewalTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置授权状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_state")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_state")]
        public string AuthorizationState { get; set; } = default!;

        /// <summary>
        /// 获取或设置苹果订阅信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apple_subscription_info")]
        [System.Text.Json.Serialization.JsonPropertyName("apple_subscription_info")]
        public Types.AppleSubscriptionInfo? AppleSubscriptionInfo { get; set; }
    }
}
