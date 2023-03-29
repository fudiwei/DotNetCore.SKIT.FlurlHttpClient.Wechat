namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/shop/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierShopGetRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierShopGetRequest, ChannelsECLeagueHeadSupplierShopGetResponse>
    {
        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;
    }
}
