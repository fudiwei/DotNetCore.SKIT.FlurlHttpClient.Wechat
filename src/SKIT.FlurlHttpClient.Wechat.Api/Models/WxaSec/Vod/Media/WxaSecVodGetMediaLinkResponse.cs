namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getmedialink 接口的响应。</para>
    /// </summary>
    public class WxaSecVodGetMediaLinkResponse : WechatApiResponse
    {
        public static class Types
        {
            public class MediaInfo
            {
                /// <summary>
                /// 获取或设置媒资文件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long MediaId { get; set; }

                /// <summary>
                /// 获取或设置视频名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string MediaName { get; set; } = default!;

                /// <summary>
                /// 获取或设置描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("duration")]
                [System.Text.Json.Serialization.JsonPropertyName("duration")]
                public int Duration { get; set; }

                /// <summary>
                /// 获取或设置封面图片临时链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cover_url")]
                [System.Text.Json.Serialization.JsonPropertyName("cover_url")]
                public string CoverUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置 MP4 视频临时链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mp4_url")]
                [System.Text.Json.Serialization.JsonPropertyName("mp4_url")]
                public string VideoMp4Url { get; set; } = default!;

                /// <summary>
                /// 获取或设置 HLS 视频临时链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hls_url")]
                [System.Text.Json.Serialization.JsonPropertyName("hls_url")]
                public string VideoHlsUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置媒资信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_info")]
        [System.Text.Json.Serialization.JsonPropertyName("media_info")]
        public Types.MediaInfo MediaInfo { get; set; } = default!;
    }
}
