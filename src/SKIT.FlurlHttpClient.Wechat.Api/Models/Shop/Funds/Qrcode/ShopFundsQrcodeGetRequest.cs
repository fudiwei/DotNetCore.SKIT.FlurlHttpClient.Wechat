namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/qrcode/get 接口的请求。</para>
    /// </summary>
    public class ShopFundsQrcodeGetRequest : WechatApiRequest, IInferable<ShopFundsQrcodeGetRequest, ShopFundsQrcodeGetResponse>
    {
        /// <summary>
        /// 获取或设置二维码 Ticket。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_ticket")]
        public string QrcodeTicket { get; set; } = string.Empty;
    }
}
