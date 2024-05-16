namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/sign-plan/partner/user-sign-plans 接口的响应。</para>
    /// </summary>
    public class CreatePayScorePartnerSignPlanUserSignPlanResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class SignPlan : CreatePayScoreSignPlanUserSignPlanResponse.Types.SignPlan
            {
                /// <summary>
                /// 获取或设置子商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
                public string SubMerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置子商户 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
                public string? SubAppId { get; set; }

                /// <summary>
                /// 获取或设置用户在子商户下的唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
                public string? SubOpenId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置跳转微信侧小程序订单数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package")]
        [System.Text.Json.Serialization.JsonPropertyName("package")]
        public string Package { get; set; } = default!;

        /// <summary>
        /// 获取或设置待签约计划信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_plan")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_plan")]
        public Types.SignPlan SignPlan { get; set; } = default!;
    }
}
