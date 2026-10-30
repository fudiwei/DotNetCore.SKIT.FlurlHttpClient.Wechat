namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ec/basics/img/uploadv2 接口的响应。</para>
    /// </summary>
    public class ShopECBasicsImageUploadV2Response : WechatApiResponse
    {
        public static class Types
        {
            public class ImageInfo
            {
                /// <summary>
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("img_url")]
                public string? ImageUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置图片信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_info")]
        [System.Text.Json.Serialization.JsonPropertyName("img_info")]
        public Types.ImageInfo? ImageInfo { get; set; }
    }
}
