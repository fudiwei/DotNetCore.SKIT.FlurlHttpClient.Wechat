namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/promotion/plan/list 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeaguePromotionPlanListRequest : WechatApiRequest, IInferable<ChannelsECLeaguePromotionPlanListRequest, ChannelsECLeaguePromotionPlanListResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// 获取或设置推广计划类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_plan_type")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_plan_type")]
        public int? PromotionPlanType { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_index")]
        [System.Text.Json.Serialization.JsonPropertyName("page_index")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;
    }
}
