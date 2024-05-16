namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/sign-plan/partner/user-sign-plans 接口的请求。</para>
    /// </summary>
    public class CreatePayScorePartnerSignPlanUserSignPlanRequest : CreatePayScoreSignPlanUserSignPlanRequest
    {
        public static new class Types
        {
            public class SignPlanDetail : CreatePayScoreSignPlanUserSignPlanRequest.Types.SignPlanDetail
            {
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string SubAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户在子商户下的唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }
    }
}
