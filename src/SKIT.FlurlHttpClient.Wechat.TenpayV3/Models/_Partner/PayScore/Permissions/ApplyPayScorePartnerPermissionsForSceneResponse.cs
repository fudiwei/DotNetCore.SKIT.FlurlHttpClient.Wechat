namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/partner/permissions/apply-for-scene 接口的响应。</para>
    /// </summary>
    public class ApplyPayScorePartnerPermissionsForSceneResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置授权场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public string Scene { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付交易中授权 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_permissions_token")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_permissions_token")]
        public string? TransactionPermissionsToken { get; set; }
    }
}
