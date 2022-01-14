namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/common/upload_img 接口的响应。</para>
    /// </summary>
    public class MerchantCommonUploadImageResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_url")]
        [System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string ImageUrl { get; set; } = default!;
    }
}
