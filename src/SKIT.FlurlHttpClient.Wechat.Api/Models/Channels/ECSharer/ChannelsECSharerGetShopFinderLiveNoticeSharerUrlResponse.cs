namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/sharer/get_shop_finder_live_notice_sharer_url 接口的响应。</para>
    /// </summary>
    public class ChannelsECSharerGetShopFinderLiveNoticeSharerUrlResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置分享链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;
    }
}
