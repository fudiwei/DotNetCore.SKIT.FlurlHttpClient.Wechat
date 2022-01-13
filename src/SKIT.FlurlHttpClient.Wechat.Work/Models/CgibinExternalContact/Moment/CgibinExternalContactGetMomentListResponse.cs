namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_moment_list 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetMomentListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Moment
            {
                public static class Types
                {
                    public class Text
                    {
                        /// <summary>
                        /// 获取或设置文本内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;
                    }

                    public class Image
                    {
                        /// <summary>
                        /// 获取或设置图片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string MediaId { get; set; } = default!;
                    }

                    public class Video
                    {
                        /// <summary>
                        /// 获取或设置视频 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string MediaId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频封面 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("thumb_media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("thumb_media_id")]
                        public string? ThumbnailMediaId { get; set; }
                    }

                    public class Link
                    {
                        /// <summary>
                        /// 获取或设置网页 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置网页标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string? Title { get; set; }
                    }

                    public class Location
                    {
                        /// <summary>
                        /// 获取或设置地理位置经度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("longitude")]
                        [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                        public double Longitude { get; set; }

                        /// <summary>
                        /// 获取或设置地理位置纬度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("latitude")]
                        [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                        public double Latitude { get; set; }

                        /// <summary>
                        /// 获取或设置地理位置名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置朋友圈 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("moment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("moment_id")]
                public string MomentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建者的成员账号或外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator")]
                [System.Text.Json.Serialization.JsonPropertyName("creator")]
                public string CreatorUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_type")]
                [System.Text.Json.Serialization.JsonPropertyName("create_type")]
                public int CreateType { get; set; }

                /// <summary>
                /// 获取或设置可见类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("visible_type")]
                [System.Text.Json.Serialization.JsonPropertyName("visible_type")]
                public int VisibleType { get; set; }

                /// <summary>
                /// 获取或设置文本消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public Types.Text? Text { get; set; }

                /// <summary>
                /// 获取或设置图片消息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image")]
                [System.Text.Json.Serialization.JsonPropertyName("image")]
                public Types.Image[]? ImageList { get; set; }

                /// <summary>
                /// 获取或设置视频消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video")]
                [System.Text.Json.Serialization.JsonPropertyName("video")]
                public Types.Video? Video { get; set; }

                /// <summary>
                /// 获取或设置网页消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link")]
                [System.Text.Json.Serialization.JsonPropertyName("link")]
                public Types.Link? Link { get; set; }

                /// <summary>
                /// 获取或设置地理位置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public Types.Location? Location { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置朋友圈列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("moment_list")]
        [System.Text.Json.Serialization.JsonPropertyName("moment_list")]
        public Types.Moment[] MomentList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
