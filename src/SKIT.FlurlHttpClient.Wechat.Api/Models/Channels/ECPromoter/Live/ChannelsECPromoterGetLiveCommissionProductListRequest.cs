namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_live_commission_product_list 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetLiveCommissionProductListRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetLiveCommissionProductListRequest, ChannelsECPromoterGetLiveCommissionProductListResponse>
    {
        /// <summary>
        /// 获取或设置达人平台 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talent_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
        public string TalentAppId { get; set; } = string.Empty;

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
