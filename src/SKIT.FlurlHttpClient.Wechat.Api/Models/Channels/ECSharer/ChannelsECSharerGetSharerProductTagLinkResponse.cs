using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/sharer/get_sharer_product_taglink 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2025-03-07 下线。")]
    public class ChannelsECSharerGetSharerProductTagLinkResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商品微信口令。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_taglink")]
        [System.Text.Json.Serialization.JsonPropertyName("product_taglink")]
        public string ProductTagLink { get; set; } = default!;
    }
}
