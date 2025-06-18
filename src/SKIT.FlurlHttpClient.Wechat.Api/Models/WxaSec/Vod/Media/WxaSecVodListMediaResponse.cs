namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/listmedia 接口的响应。</para>
    /// </summary>
    public class WxaSecVodListMediaResponse : WechatApiResponse
    {
        public static class Types
        {
            public class MediaInfo
            {
                public static class Types
                {
                    public class AuditDetail
                    {
                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置提审时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置审核时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_time")]
                        public long? AuditTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置审核备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? Reason { get; set; }

                        /// <summary>
                        /// 获取或设置审核证据截图 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("evidence_material_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("evidence_material_id_list")]
                        public string[]? EvidenceMaterialMediaIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置所属剧目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("drama_id")]
                [System.Text.Json.Serialization.JsonPropertyName("drama_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? DramaId { get; set; }

                /// <summary>
                /// 获取或设置描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

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
                /// 获取或设置文件大小（单位：字节）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_size")]
                [System.Text.Json.Serialization.JsonPropertyName("file_size")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int FileSize { get; set; }

                /// <summary>
                /// 获取或设置时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("duration")]
                [System.Text.Json.Serialization.JsonPropertyName("duration")]
                public int Duration { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置封面图片临时链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cover_url")]
                [System.Text.Json.Serialization.JsonPropertyName("cover_url")]
                public string? CoverUrl { get; set; }

                /// <summary>
                /// 获取或设置原始视频临时链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_url")]
                [System.Text.Json.Serialization.JsonPropertyName("original_url")]
                public string? VideoOriginalUrl { get; set; }

                /// <summary>
                /// 获取或设置 MP4 视频临时链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mp4_url")]
                [System.Text.Json.Serialization.JsonPropertyName("mp4_url")]
                public string? VideoMp4Url { get; set; }

                /// <summary>
                /// 获取或设置 HLS 视频临时链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hls_url")]
                [System.Text.Json.Serialization.JsonPropertyName("hls_url")]
                public string? VideoHlsUrl { get; set; }

                /// <summary>
                /// 获取或设置审核详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_detail")]
                public Types.AuditDetail? AuditDetail { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置媒资信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("media_info_list")]
        public Types.MediaInfo[] MediaInfoList { get; set; } = default!;
    }
}
