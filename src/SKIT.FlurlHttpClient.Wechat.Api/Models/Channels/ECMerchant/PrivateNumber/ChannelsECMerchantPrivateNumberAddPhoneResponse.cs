namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/merchant/privatenumber/addphone 接口的响应。</para>
    /// </summary>
    public class ChannelsECMerchantPrivateNumberAddPhoneResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置认证链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_url")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_url")]
        public string QrcodeUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置认证状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
