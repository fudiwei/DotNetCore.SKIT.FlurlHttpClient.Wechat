namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/img/upload 接口的响应。</para>
    /// </summary>
    public class ChannelsECBasicsImageUploadResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PictureFile
            {
                /// <summary>
                /// 获取或设置 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string? MediaId { get; set; }

                /// <summary>
                /// 获取或设置支付专用 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_media_id")]
                public string? PayMediaId { get; set; }

                /// <summary>
                /// 获取或设置图片临时 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("temp_img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("temp_img_url")]
                public string? TempImageUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置图片文件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pic_file")]
        [System.Text.Json.Serialization.JsonPropertyName("pic_file")]
        public Types.PictureFile PictureFile { get; set; } = default!;
    }
}
