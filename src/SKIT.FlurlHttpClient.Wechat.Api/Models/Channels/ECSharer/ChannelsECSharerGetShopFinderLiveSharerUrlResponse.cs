using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/sharer/get_shop_finder_live_sharer_url 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2025-03-07 下线。")]
    public class ChannelsECSharerGetShopFinderLiveSharerUrlResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置分享链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;
    }
}
