namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/membercard-open/cards/{card_id}/qrcode 接口的响应。</para>
    /// </summary>
    public class CreateMarketingMemberCardOpenCardQrcodeResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置二维码对应的 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string QrcodeUrl { get; set; } = default!;
    }
}
