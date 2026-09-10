namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/image_upload 接口的响应。</para>
    /// </summary>
    public class CgibinWedocImageUploadResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string ImageUrl { get; set; } = default!;

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
        /// 获取或设置图片大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int Size { get; set; }
    }
}
