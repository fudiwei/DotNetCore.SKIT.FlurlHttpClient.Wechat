namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/product/list/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECCompassShopProductListGetRequest : WechatApiRequest, IInferable<ChannelsECCompassShopProductListGetRequest, ChannelsECCompassShopProductListGetResponse>
    {
        /// <summary>
        /// 获取或设置日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ds")]
        [System.Text.Json.Serialization.JsonPropertyName("ds")]
        public string DateString { get; set; } = string.Empty;
    }
}
