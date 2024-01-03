namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 MALL_AUTH.ACTIVATE_CARD 通知的数据。</para>
    /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/smart-business-circle/authorization-services.html </para>
    /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/smart-business-circle/authorization-services.html </para>
    /// </summary>
    public class MallAuthResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户授权类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_type")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public string AuthType { get; set; } = default!;
    }
}
