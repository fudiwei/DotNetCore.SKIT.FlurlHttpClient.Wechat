namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguideimagematerial 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideImageMaterialResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ImageMaterial
            {
                /// <summary>
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("picurl")]
                [System.Text.Json.Serialization.JsonPropertyName("picurl")]
                public string PictureUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置图片素材列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_list")]
        [System.Text.Json.Serialization.JsonPropertyName("model_list")]
        public Types.ImageMaterial[] ImageList { get; set; } = default!;

        /// <summary>
        /// 获取或设置图片素材总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
