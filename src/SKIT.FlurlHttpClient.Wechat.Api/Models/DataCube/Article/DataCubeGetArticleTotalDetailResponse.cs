namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getarticletotaldetail 接口的响应。</para>
    /// </summary>
    public class DataCubeGetArticleTotalDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Detail
                    {
                        public static class Types
                        {
                            public class ReadSourceData : DataCubeGetArticleReadResponse.Types.Data.Types.Detail.Types.ReadSourceData
                            {
                            }

                            public class ReadJumpPosition
                            {
                                /// <summary>
                                /// 获取或设置跳出位置。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("position")]
                                [System.Text.Json.Serialization.JsonPropertyName("position")]
                                public int Position { get; set; }

                                /// <summary>
                                /// 获取或设置跳出率（范围：0～1）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rate")]
                                [System.Text.Json.Serialization.JsonPropertyName("rate")]
                                public decimal Rate { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置统计的日期（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stat_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("stat_date")]
                        public string? StatDateString { get; set; }

                        /// <summary>
                        /// 获取或设置阅读人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("read_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("read_user")]
                        public int ReadUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置阅读场景数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("read_user_source")]
                        [System.Text.Json.Serialization.JsonPropertyName("read_user_source")]
                        public List<Types.ReadSourceData>? ReadUserSourceList { get; set; }

                        /// <summary>
                        /// 获取或设置分享人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_user")]
                        public int ShareUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置在看人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("zaikan_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("zaikan_user")]
                        public int ZaikanUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置点赞人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("like_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("like_user")]
                        public int LikeUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置留言条数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_count")]
                        public int CommentCount { get; set; }

                        /// <summary>
                        /// 获取或设置收藏人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("collection_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("collection_user")]
                        public int CollectionUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置赞赏金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("praise_money")]
                        [System.Text.Json.Serialization.JsonPropertyName("praise_money")]
                        public int PraiseMoney { get; set; }

                        /// <summary>
                        /// 获取或设置阅读后关注人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("read_subscribe_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("read_subscribe_user")]
                        public int ReadSubscribeUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置阅读送达率（范围：0～1）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("read_delivery_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("read_delivery_rate")]
                        public decimal ReadDeliveryRate { get; set; }

                        /// <summary>
                        /// 获取或设置阅读完成率（范围：0～1）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("read_finish_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("read_finish_rate")]
                        public decimal ReadFinishRate { get; set; }

                        /// <summary>
                        /// 获取或设置阅读平均时长（单位：分钟）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("read_avg_activetime")]
                        [System.Text.Json.Serialization.JsonPropertyName("read_avg_activetime")]
                        public decimal ReadAverageActiveTime { get; set; }

                        /// <summary>
                        /// 获取或设置阅读跳出位置列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("read_jump_position")]
                        [System.Text.Json.Serialization.JsonPropertyName("read_jump_position")]
                        public List<Types.ReadJumpPosition>? ReadJumpPositionList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置数据的日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ref_date")]
                [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
                public string? RefDateString { get; set; }

                /// <summary>
                /// 获取或设置图文消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgid")]
                [System.Text.Json.Serialization.JsonPropertyName("msgid")]
                public string? MessageId { get; set; }

                /// <summary>
                /// 获取或设置发表类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("publish_type")]
                [System.Text.Json.Serialization.JsonPropertyName("publish_type")]
                public int PublishType { get; set; }

                /// <summary>
                /// 获取或设置图文标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置图文 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content_url")]
                [System.Text.Json.Serialization.JsonPropertyName("content_url")]
                public string? Url { get; set; }

                /// <summary>
                /// 获取或设置数据详情列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_list")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_list")]
                public List<Types.Detail>? DetailList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public List<Types.Data>? DataList { get; set; }

        /// <summary>
        /// 获取或设置数据是否有延迟。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_delay")]
        [System.Text.Json.Serialization.JsonPropertyName("is_delay")]
        public bool IsDelay { get; set; }
    }
}
