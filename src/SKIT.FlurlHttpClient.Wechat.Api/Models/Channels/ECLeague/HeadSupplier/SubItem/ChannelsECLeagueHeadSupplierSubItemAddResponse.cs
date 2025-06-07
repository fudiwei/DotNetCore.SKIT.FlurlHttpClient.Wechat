namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/subitem/add 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierSubItemAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置达人佣金计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_item_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_item_id")]
        public long SubItemId { get; set; }
    }
}
