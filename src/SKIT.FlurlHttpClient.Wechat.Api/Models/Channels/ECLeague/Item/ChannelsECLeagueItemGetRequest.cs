namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/item/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueItemGetRequest : WechatApiRequest, IInferable<ChannelsECLeagueItemGetRequest, ChannelsECLeagueItemGetResponse>
    {
        /// <summary>
        /// 获取或设置商品推广类别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// 获取或设置特殊推广商品计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info_id")]
        [System.Text.Json.Serialization.JsonPropertyName("info_id")]
        public long? InfoId { get; set; }

        /// <summary>
        /// 获取或设置是否获取特殊推广商品绑定的达人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_relation")]
        [System.Text.Json.Serialization.JsonPropertyName("need_relation")]
        public bool? RequireRelation { get; set; }

        /// <summary>
        /// 获取或设置是否需要返回该计划绑定达人总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("need_total_num")]
        public bool? RequireRelationTotalCount { get; set; }

        /// <summary>
        /// 获取或设置达人分页页数（从 1 开始）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_index")]
        [System.Text.Json.Serialization.JsonPropertyName("page_index")]
        public int? RelationPage { get; set; }

        /// <summary>
        /// 获取或设置达人分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? RelationLimit { get; set; }
    }
}
