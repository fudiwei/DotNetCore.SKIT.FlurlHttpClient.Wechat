namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_feed_list 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetFeedListRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetFeedListRequest, ChannelsECPromoterGetFeedListResponse>
    {
        /// <summary>
        /// 获取或设置达人平台 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talent_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
        public string TalentAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置达人平台的视频号导出名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_exportusername")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_exportusername")]
        public string? FinderExportUsername { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? Cursor { get; set; }
    }
}
