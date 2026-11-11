namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/acquiringbank/permissions/authorization-code/{authorization_code} 接口的响应。</para>
    /// </summary>
    public class GetPayScoreAcquiringBankPermissionsByAuthorizationCodeResponse : GetPayScorePermissionsByAuthorizationCodeResponse
    {
        /// <summary>
        /// 获取或设置渠道商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置子商户用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

        /// <summary>
        /// 获取或设置用户标签。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_label")]
        [System.Text.Json.Serialization.JsonPropertyName("user_label")]
        public string? UserLabel { get; set; }
    }
}
