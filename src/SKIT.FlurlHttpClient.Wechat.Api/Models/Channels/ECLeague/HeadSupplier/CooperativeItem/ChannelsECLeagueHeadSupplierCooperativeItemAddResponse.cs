namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/cooperativeitem/add 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierCooperativeItemAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置机构合作计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cooperative_item_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cooperative_item_id")]
        public long CooperativeItemId { get; set; }
    }
}
