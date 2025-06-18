using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/sharer/get_shop_finder_live_notice_sharer_url 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2025-03-07 下线。")]
    public class ChannelsECSharerGetShopFinderLiveNoticeSharerUrlRequest : WechatApiRequest, IInferable<ChannelsECSharerGetShopFinderLiveNoticeSharerUrlRequest, ChannelsECSharerGetShopFinderLiveNoticeSharerUrlResponse>
    {
        /// <summary>
        /// 获取或设置直播预告 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notice_id")]
        [System.Text.Json.Serialization.JsonPropertyName("notice_id")]
        public string NoticeId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_id")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
        public string FinderId { get; set; } = string.Empty;
    }
}
