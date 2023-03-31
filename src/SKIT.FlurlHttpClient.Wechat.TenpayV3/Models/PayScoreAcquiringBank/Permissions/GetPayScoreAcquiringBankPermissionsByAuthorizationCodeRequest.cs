namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/acquiringbank/permissions/authorization-code/{authorization_code} 接口的请求。</para>
    /// </summary>
    public class GetPayScoreAcquiringBankPermissionsByAuthorizationCodeRequest : GetPayScorePartnerPermissionsByAuthorizationCodeRequest
    {
        /// <summary>
        /// 获取或设置渠道商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ChannelId { get; set; } = string.Empty;
    }
}
