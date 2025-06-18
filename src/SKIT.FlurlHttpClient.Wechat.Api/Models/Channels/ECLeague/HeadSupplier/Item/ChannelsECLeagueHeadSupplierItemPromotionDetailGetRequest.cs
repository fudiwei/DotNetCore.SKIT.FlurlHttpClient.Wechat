namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/item/promotiondetail/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierItemPromotionDetailGetRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierItemPromotionDetailGetRequest, ChannelsECLeagueHeadSupplierItemPromotionDetailGetResponse>
    {
        /// <summary>
        /// 获取或设置团长商品链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_supplier_item_link")]
        [System.Text.Json.Serialization.JsonPropertyName("head_supplier_item_link")]
        public string HeadSupplierItemLink { get; set; } = string.Empty;
    }
}
