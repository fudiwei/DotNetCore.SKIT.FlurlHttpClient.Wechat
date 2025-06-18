namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/sale/profile/data/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECCompassShopSaleProfileDataGetRequest : WechatApiRequest, IInferable<ChannelsECCompassShopSaleProfileDataGetRequest, ChannelsECCompassShopSaleProfileDataGetResponse>
    {
        /// <summary>
        /// 获取或设置用户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ds")]
        [System.Text.Json.Serialization.JsonPropertyName("ds")]
        public string DateString { get; set; } = string.Empty;
    }
}
