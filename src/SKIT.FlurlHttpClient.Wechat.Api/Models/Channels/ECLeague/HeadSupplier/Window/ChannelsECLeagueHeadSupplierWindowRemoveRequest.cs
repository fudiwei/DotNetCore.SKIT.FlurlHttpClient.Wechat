namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/window/remove 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierWindowRemoveRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierWindowRemoveRequest, ChannelsECLeagueHeadSupplierWindowRemoveResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置商品在橱窗的 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_window_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_window_id")]
        public long? ProductWindowId { get; set; }

        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_id")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
        public string? FinderId { get; set; }

        /// <summary>
        /// 获取或设置视频号 OpenFinderId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openfinderid")]
        [System.Text.Json.Serialization.JsonPropertyName("openfinderid")]
        public string? OpenFinderId { get; set; }

        /// <summary>
        /// 获取或设置带货达人 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opentalentid")]
        [System.Text.Json.Serialization.JsonPropertyName("opentalentid")]
        public string? OpenTalentId { get; set; }
    }
}
