namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/h5url/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductH5UrlGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商品 H5 短链。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_h5url")]
        [System.Text.Json.Serialization.JsonPropertyName("product_h5url")]
        public string ProductH5Url { get; set; } = default!;
    }
}
