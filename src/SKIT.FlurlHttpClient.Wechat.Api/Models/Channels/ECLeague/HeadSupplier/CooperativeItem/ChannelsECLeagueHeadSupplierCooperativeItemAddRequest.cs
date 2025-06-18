namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/cooperativeitem/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierCooperativeItemAddRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierCooperativeItemAddRequest, ChannelsECLeagueHeadSupplierCooperativeItemAddResponse>
    {
        /// <summary>
        /// 获取或设置机构推广商品链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_supplier_item_link")]
        [System.Text.Json.Serialization.JsonPropertyName("head_supplier_item_link")]
        public string HeadSupplierItemLink { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否隐藏。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hidden_flag")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("hidden_flag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsHidden { get; set; }
    }
}
