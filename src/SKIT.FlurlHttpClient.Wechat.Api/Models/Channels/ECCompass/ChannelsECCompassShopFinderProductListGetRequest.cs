namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/finder/product/list/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECCompassShopFinderProductListGetRequest : WechatApiRequest, IInferable<ChannelsECCompassShopFinderProductListGetRequest, ChannelsECCompassShopFinderProductListGetResponse>
    {
        /// <summary>
        /// 获取或设置日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ds")]
        [System.Text.Json.Serialization.JsonPropertyName("ds")]
        public string DateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_id")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
        public string? FinderId { get; set; }

        /// <summary>
        /// 获取或设置达人号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("talent_id")]
        public string? TalentId { get; set; }

        /// <summary>
        /// 获取或设置公众号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mp_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mp_id")]
        public string? MpId { get; set; }
    }
}
