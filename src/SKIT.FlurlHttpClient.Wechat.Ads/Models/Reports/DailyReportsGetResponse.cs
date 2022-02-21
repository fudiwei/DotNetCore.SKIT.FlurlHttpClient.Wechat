namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /daily_reports/get 接口的响应。</para>
    /// </summary>
    public class DailyReportsGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class DailyReport
                    {
                        /// <summary>
                        /// 获取或设置查询日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置推广计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("campaign_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
                        public long? CampaignId { get; set; }

                        /// <summary>
                        /// 获取或设置推广计划名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("campaign_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("campaign_name")]
                        public string? CampaignName { get; set; }

                        /// <summary>
                        /// 获取或设置广告组 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adgroup_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("adgroup_id")]
                        public long? AdGroupId { get; set; }

                        /// <summary>
                        /// 获取或设置广告组名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adgroup_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("adgroup_name")]
                        public string? AdGroupName { get; set; }

                        /// <summary>
                        /// 获取或设置曝光量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("impression")]
                        [System.Text.Json.Serialization.JsonPropertyName("impression")]
                        public int ImpressCount { get; set; }

                        /// <summary>
                        /// 获取或设置点击量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("click")]
                        [System.Text.Json.Serialization.JsonPropertyName("click")]
                        public int ClickCount { get; set; }

                        /// <summary>
                        /// 获取或设置消耗金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cost")]
                        [System.Text.Json.Serialization.JsonPropertyName("cost")]
                        public int Cost { get; set; }

                        /// <summary>
                        /// 获取或设置点赞或评论量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("like_or_comment")]
                        [System.Text.Json.Serialization.JsonPropertyName("like_or_comment")]
                        public int LikeOrCommentCount { get; set; }

                        /// <summary>
                        /// 获取或设置图片点击量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_click")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_click")]
                        public int ImageClickCount { get; set; }

                        /// <summary>
                        /// 获取或设置关注量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("follow")]
                        [System.Text.Json.Serialization.JsonPropertyName("follow")]
                        public int FollowCount { get; set; }

                        /// <summary>
                        /// 获取或设置转发量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share")]
                        [System.Text.Json.Serialization.JsonPropertyName("share")]
                        public int ShareCount { get; set; }

                        /// <summary>
                        /// 获取或设置本地门店访问人次。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lbs_wechat_pv")]
                        [System.Text.Json.Serialization.JsonPropertyName("lbs_wechat_pv")]
                        public int LBSWechatPV { get; set; }

                        /// <summary>
                        /// 获取或设置本地门店访问人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lbs_wechat_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("lbs_wechat_uv")]
                        public int LBSWechatUV { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置日报列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.DailyReport[] DailyReportList { get; set; } = default!;

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
