namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/shop/qrcode/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECBasicsShopQrcodeGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置小店二维码链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_qrcode")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_qrcode")]
        public string ShopQrcode { get; set; } = default!;
    }
}
