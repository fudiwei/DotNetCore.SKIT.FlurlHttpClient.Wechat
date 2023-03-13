namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/sharer/bind 接口的响应。</para>
    /// </summary>
    public class ChannelsECSharerBindResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置邀请二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_img")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_img")]
        public string QrcodeImageUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置 Base64 编码的邀请二维码数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_img_base64")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_img_base64")]
        public string EncodingQrcodeImageData { get; set; } = default!;
    }
}
