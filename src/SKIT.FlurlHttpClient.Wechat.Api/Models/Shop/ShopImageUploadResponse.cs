namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/img/upload 接口的响应。</para>
    /// </summary>
    public class ShopImageUploadResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Image
            {
                /// <summary>
                /// 获取或设置 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string? MediaId { get; set; }

                /// <summary>
                /// 获取或设置图片临时 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("temp_img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("temp_img_url")]
                public string? TempImageUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置图片信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_info")]
        [System.Text.Json.Serialization.JsonPropertyName("img_info")]
        public Types.Image Image { get; set; } = default!;
    }
}
