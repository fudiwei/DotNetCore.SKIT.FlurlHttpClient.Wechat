namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/qrcode/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductQrcodeGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商品二维码链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_qrcode")]
        [System.Text.Json.Serialization.JsonPropertyName("product_qrcode")]
        public string ProductQrcode { get; set; } = default!;
    }
}
