namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/item/delete 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueItemDeleteRequest : WechatApiRequest, IInferable<ChannelsECLeagueItemDeleteRequest, ChannelsECLeagueItemDeleteResponse>
    {
        /// <summary>
        /// 获取或设置商品推广类别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

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
    }
}
