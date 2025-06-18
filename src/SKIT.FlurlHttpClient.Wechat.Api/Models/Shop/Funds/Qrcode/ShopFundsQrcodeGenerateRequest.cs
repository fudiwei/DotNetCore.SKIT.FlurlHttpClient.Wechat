namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/qrcode/gen 接口的请求。</para>
    /// </summary>
    public class ShopFundsQrcodeGenerateRequest : WechatApiRequest, IInferable<ShopFundsQrcodeGenerateRequest, ShopFundsQrcodeGenerateResponse>
    {
        /// <summary>
        /// 获取或设置需要验证的身份类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identity_type")]
        [System.Text.Json.Serialization.JsonPropertyName("identity_type")]
        public int IdentityType { get; set; }
    }
}
