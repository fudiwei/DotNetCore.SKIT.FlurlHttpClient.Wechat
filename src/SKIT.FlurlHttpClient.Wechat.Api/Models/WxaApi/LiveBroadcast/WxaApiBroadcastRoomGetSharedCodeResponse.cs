namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/broadcast/room/getsharedcode 接口的响应。</para>
    /// </summary>
    public class WxaApiBroadcastRoomGetSharedCodeResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置分享二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cdnUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("cdnUrl")]
        public string QrcodeUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置分享海报 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("posterUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("posterUrl")]
        public string PosterUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置分享路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pagePath")]
        [System.Text.Json.Serialization.JsonPropertyName("pagePath")]
        public string PagePath { get; set; } = default!;
    }
}
