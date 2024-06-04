namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/sharer/get_shop_finder_live_sharer_url 接口的请求。</para>
    /// </summary>
    public class ChannelsECSharerGetShopFinderLiveSharerUrlRequest : WechatApiRequest, IInferable<ChannelsECSharerGetShopFinderLiveSharerUrlRequest, ChannelsECSharerGetShopFinderLiveSharerUrlResponse>
    {
        /// <summary>
        /// 获取或设置直播 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("export_id")]
        [System.Text.Json.Serialization.JsonPropertyName("export_id")]
        public string ExportId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_id")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
        public string FinderId { get; set; } = string.Empty;
    }
}
