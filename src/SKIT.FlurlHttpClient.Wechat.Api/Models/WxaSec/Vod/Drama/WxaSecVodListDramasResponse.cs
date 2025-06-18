namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/listdramas 接口的响应。</para>
    /// </summary>
    public class WxaSecVodListDramasResponse : WechatApiResponse
    {
        public static class Types
        {
            public class DramaInfo
            {
                public static class Types
                {
                    public class Media
                    {
                        /// <summary>
                        /// 获取或设置媒资文件 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long MediaId { get; set; }
                    }

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
                    }

                    public class ActorList
                    {
                        /// <summary>
                        /// 获取或设置演员列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actor")]
                        [System.Text.Json.Serialization.JsonPropertyName("actor")]
                        public ActorItem[] Items { get; set; } = default!;
                    }

                    public class ActorItem
                    {
                        /// <summary>
                        /// 获取或设置演员姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置演员照片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("photo_material_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("photo_material_id")]
                        public string PhotoMediaId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置饰演角色。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("role")]
                        [System.Text.Json.Serialization.JsonPropertyName("role")]
                        public string Role { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置演员简介。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("profile")]
                        [System.Text.Json.Serialization.JsonPropertyName("profile")]
                        public string Profile { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置剧目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("drama_id")]
                [System.Text.Json.Serialization.JsonPropertyName("drama_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long DramaId { get; set; }

                /// <summary>
                /// 获取或设置剧名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置媒资文件数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_count")]
                [System.Text.Json.Serialization.JsonPropertyName("media_count")]
                public int MediaCount { get; set; }

                /// <summary>
                /// 获取或设置媒资文件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_list")]
                [System.Text.Json.Serialization.JsonPropertyName("media_list")]
                public Types.Media[] MediaList { get; set; } = default!;

                /// <summary>
                /// 获取或设置剧目状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置封面图片临时链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cover_url")]
                [System.Text.Json.Serialization.JsonPropertyName("cover_url")]
                public string? CoverUrl { get; set; }

                /// <summary>
                /// 获取或设置推广海报临时链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_poster")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_poster")]
                public string? PromotionPosterUrl { get; set; }

                /// <summary>
                /// 获取或设置剧目推荐语。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recommendations")]
                [System.Text.Json.Serialization.JsonPropertyName("recommendations")]
                public string? Recommendations { get; set; }

                /// <summary>
                /// 获取或设置制作方。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("producer")]
                [System.Text.Json.Serialization.JsonPropertyName("producer")]
                public string? Producer { get; set; }

                /// <summary>
                /// 获取或设置编剧。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("playwright")]
                [System.Text.Json.Serialization.JsonPropertyName("playwright")]
                public string? Playwright { get; set; }

                /// <summary>
                /// 获取或设置演员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actor_list")]
                [System.Text.Json.Serialization.JsonPropertyName("actor_list")]
                public Types.ActorList? ActorList { get; set; }

                /// <summary>
                /// 获取或设置广播电视节目制作经营许可证编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("production_license")]
                [System.Text.Json.Serialization.JsonPropertyName("production_license")]
                public string? ProductionLicenseNumber { get; set; }

                /// <summary>
                /// 获取或设置审核详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_detail")]
                public Types.AuditDetail? AuditDetail { get; set; }

                /// <summary>
                /// 获取或设置是否加急审核。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expedited")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanReadOnlyConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("expedited")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanReadOnlyConverter))]
                public bool? IsExpedited { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置剧目信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("drama_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("drama_info_list")]
        public Types.DramaInfo[] DramaInfoList { get; set; } = default!;
    }
}
