namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/acquiringbank/permissions/authorization-code/{authorization_code} 接口的请求。</para>
    /// </summary>
    public class GetPayScoreAcquiringBankPermissionsByAuthorizationCodeRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置渠道商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置授权协议号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? AuthorizationCode { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ServiceId { get; set; }
    }
}
