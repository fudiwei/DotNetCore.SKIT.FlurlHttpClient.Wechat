namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/overall/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECCompassShopOverallGetRequest : WechatApiRequest, IInferable<ChannelsECCompassShopOverallGetRequest, ChannelsECCompassShopOverallGetResponse>
    {
        /// <summary>
        /// 获取或设置日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ds")]
        [System.Text.Json.Serialization.JsonPropertyName("ds")]
        public string DateString { get; set; } = string.Empty;
    }
}
