namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /images/get 接口的响应。</para>
    /// </summary>
    public class ImagesGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Image
                    {
                        /// <summary>
                        /// 获取或设置图片 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_id")]
                        public string ImageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图片类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图片宽度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        public int Width { get; set; }

                        /// <summary>
                        /// 获取或设置图片高度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        public int Height { get; set; }

                        /// <summary>
                        /// 获取或设置图片文件大小（单位：字节）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("file_size")]
                        [System.Text.Json.Serialization.JsonPropertyName("file_size")]
                        public int FileSize { get; set; }

                        /// <summary>
                        /// 获取或设置图片文件的 MD5 哈希值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("signature")]
                        [System.Text.Json.Serialization.JsonPropertyName("signature")]
                        public string FileHash { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图片预览地址 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("preview_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("preview_url")]
                        public string PreviewUrl { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置图片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Image[] ImageList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public CommonPagination Pagination { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
