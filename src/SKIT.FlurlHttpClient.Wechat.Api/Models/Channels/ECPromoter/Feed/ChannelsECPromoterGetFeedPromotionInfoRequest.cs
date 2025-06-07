using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_feed_promotion_info 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetFeedPromotionInfoRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetFeedPromotionInfoRequest, ChannelsECPromoterGetFeedPromotionInfoResponse>
    {
        public static class Types
        {
            public class Feed
            {
                /// <summary>
                /// 获取或设置短视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("export_id")]
                [System.Text.Json.Serialization.JsonPropertyName("export_id")]
                public string ExportId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置达人平台 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talent_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
        public string TalentAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置推客 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
        public string? SharerAppId { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mini_program_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("mini_program_appid")]
        public string MiniProgramAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置短视频列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feed_list")]
        [System.Text.Json.Serialization.JsonPropertyName("feed_list")]
        public IList<Types.Feed> FeedList { get; set; } = new List<Types.Feed>();
    }
}
