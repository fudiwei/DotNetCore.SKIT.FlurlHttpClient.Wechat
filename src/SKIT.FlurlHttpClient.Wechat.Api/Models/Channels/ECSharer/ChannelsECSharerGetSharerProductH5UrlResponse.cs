namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/sharer/get_sharer_product_h5url 接口的响应。</para>
    /// </summary>
    public class ChannelsECSharerGetSharerProductH5UrlResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商品 H5 短链。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_h5url")]
        [System.Text.Json.Serialization.JsonPropertyName("product_h5url")]
        public string ProductH5Url { get; set; } = default!;
    }
}
