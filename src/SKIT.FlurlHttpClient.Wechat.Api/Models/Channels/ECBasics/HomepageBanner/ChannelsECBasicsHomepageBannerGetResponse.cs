namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/homepage/banner/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECBasicsHomepageBannerGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Apply
            {
                /// <summary>
                /// 获取或设置申请 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_id")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ApplyId { get; set; }

                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public int State { get; set; }

                /// <summary>
                /// 获取或设置展示样式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scale")]
                [System.Text.Json.Serialization.JsonPropertyName("scale")]
                public int Scale { get; set; }

                /// <summary>
                /// 获取或设置展示位列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("banner")]
                [System.Text.Json.Serialization.JsonPropertyName("banner")]
                public ApplyBanner[] BannerList { get; set; } = default!;
            }

            public class ApplyBanner
            {
                /// <summary>
                /// 获取或设置审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_state")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_state")]
                public int AuditState { get; set; }

                /// <summary>
                /// 获取或设置审核结果描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_desc")]
                public string? AuditDescription { get; set; }

                /// <summary>
                /// 获取或设置展示位信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("banner")]
                [System.Text.Json.Serialization.JsonPropertyName("banner")]
                public BannerItem Banner { get; set; } = default!;
            }

            public class BannerList
            {
                /// <summary>
                /// 获取或设置展示样式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scale")]
                [System.Text.Json.Serialization.JsonPropertyName("scale")]
                public int Scale { get; set; }

                /// <summary>
                /// 获取或设置展示位列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("banner")]
                [System.Text.Json.Serialization.JsonPropertyName("banner")]
                public BannerItem[] Items { get; set; } = default!;
            }

            public class BannerItem
            {
                public static class Types
                {
                    public class Banner : ChannelsECBasicsHomepageBannerApplySubmitRequest.Types.BannerItem.Types.Banner
                    {
                    }

                    public class Product : ChannelsECBasicsHomepageBannerApplySubmitRequest.Types.BannerItem.Types.Product
                    {
                    }

                    public class Finder : ChannelsECBasicsHomepageBannerApplySubmitRequest.Types.BannerItem.Types.Finder
                    {
                    }

                    public class OfficialAccount : ChannelsECBasicsHomepageBannerApplySubmitRequest.Types.BannerItem.Types.OfficialAccount
                    {
                    }
                }

                /// <summary>
                /// 获取或设置展示位类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置展示位信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("banner")]
                [System.Text.Json.Serialization.JsonPropertyName("banner")]
                public Types.Banner Banner { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product")]
                [System.Text.Json.Serialization.JsonPropertyName("product")]
                public Types.Product? Product { get; set; }

                /// <summary>
                /// 获取或设置视频号信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finder")]
                [System.Text.Json.Serialization.JsonPropertyName("finder")]
                public Types.Finder? Finder { get; set; }

                /// <summary>
                /// 获取或设置公众号信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("official_account")]
                [System.Text.Json.Serialization.JsonPropertyName("official_account")]
                public Types.OfficialAccount? OfficialAccount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置当前生效的展示位列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("banner")]
        [System.Text.Json.Serialization.JsonPropertyName("banner")]
        public Types.BannerList BannerList { get; set; } = default!;

        /// <summary>
        /// 获取或设置最近一次申请信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply")]
        [System.Text.Json.Serialization.JsonPropertyName("apply")]
        public Types.Apply? Apply { get; set; }
    }
}
