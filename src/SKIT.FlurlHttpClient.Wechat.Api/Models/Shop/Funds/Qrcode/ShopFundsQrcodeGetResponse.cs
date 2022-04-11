namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/qrcode/get 接口的响应。</para>
    /// </summary>
    public class ShopFundsQrcodeGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置二维码数据（经 Base64 编码）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_buf")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_buf")]
        public string QrcodeData { get; set; } = default!;
    }
}
