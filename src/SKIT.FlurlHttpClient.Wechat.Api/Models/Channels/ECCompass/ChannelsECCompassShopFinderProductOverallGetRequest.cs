namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/finder/product/overall/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECCompassShopFinderProductOverallGetRequest : WechatApiRequest, IInferable<ChannelsECCompassShopFinderProductOverallGetRequest, ChannelsECCompassShopFinderProductOverallGetResponse>
    {
        /// <summary>
        /// 获取或设置视频号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_id")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
        public string FinderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ds")]
        [System.Text.Json.Serialization.JsonPropertyName("ds")]
        public string DateString { get; set; } = string.Empty;
    }
}
