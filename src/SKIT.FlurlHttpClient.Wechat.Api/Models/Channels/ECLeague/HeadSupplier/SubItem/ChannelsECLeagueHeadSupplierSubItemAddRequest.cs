namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/subitem/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierSubItemAddRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierSubItemAddRequest, ChannelsECLeagueHeadSupplierSubItemAddResponse>
    {
        /// <summary>
        /// 获取或设置机构合作计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cooperative_item_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cooperative_item_id")]
        public long CooperativeItemId { get; set; }

        /// <summary>
        /// 获取或设置达人佣金率（范围：0～90）。与字段 <see cref="RatioExt"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
        public int? Ratio { get; set; }

        /// <summary>
        /// 获取或设置达人精确佣金率（单位：万分数）。与字段 <see cref="Ratio"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ratio_ext")]
        [System.Text.Json.Serialization.JsonPropertyName("ratio_ext")]
        public int? RatioExt { get; set; }
    }
}
