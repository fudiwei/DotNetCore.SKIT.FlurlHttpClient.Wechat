namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /adcreatives/get 接口的响应。</para>
    /// </summary>
    public class AdCreativesGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class AdCreative
                    {
                        public static class Types
                        {
                            public class Element
                            {
                                /// <summary>
                                /// 获取或设置广告文案。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string? Title { get; set; }

                                /// <summary>
                                /// 获取或设置广告描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("description")]
                                [System.Text.Json.Serialization.JsonPropertyName("description")]
                                public string? Description { get; set; }

                                /// <summary>
                                /// 获取或设置图片 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("image")]
                                [System.Text.Json.Serialization.JsonPropertyName("image")]
                                public string? ImageId { get; set; }

                                /// <summary>
                                /// 获取或设置图片 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("image_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("image_list")]
                                public string[]? ImageIdList { get; set; }

                                /// <summary>
                                /// 获取或设置链接名称类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("link_name_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("link_name_type")]
                                public string? LinkNameType { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置推广计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("campaign_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
                        public long CampaignId { get; set; }

                        /// <summary>
                        /// 获取或设置广告创意 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adcreative_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("adcreative_id")]
                        public long AdCreativeId { get; set; }

                        /// <summary>
                        /// 获取或设置广告创意名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adcreative_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("adcreative_name")]
                        public string AdCreativeName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置广告创意规格 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adcreative_template_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("adcreative_template_id")]
                        public int AdCreativeTemplateId { get; set; }

                        /// <summary>
                        /// 获取或设置广告创意元素信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adcreative_elements")]
                        [System.Text.Json.Serialization.JsonPropertyName("adcreative_elements")]
                        public Types.Element AdCreativeElement { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置投放站点列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("site_set")]
                        [System.Text.Json.Serialization.JsonPropertyName("site_set")]
                        public string[] SiteList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置目标 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("destination_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("destination_url")]
                        public string DestinationUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置标的物类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                        public string ProductType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置标的物 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_refs_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_refs_id")]
                        public string? ProductRefId { get; set; }

                        /// <summary>
                        /// 获取或设置最近修改时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("last_modified_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("last_modified_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("created_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("created_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置广告创意列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.AdCreative[] AdCreativeList { get; set; } = default!;

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
