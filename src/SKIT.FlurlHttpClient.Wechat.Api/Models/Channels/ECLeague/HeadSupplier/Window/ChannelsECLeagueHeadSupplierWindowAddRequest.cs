namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/window/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierWindowAddRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierWindowAddRequest, ChannelsECLeagueHeadSupplierWindowAddResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

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
        /// 获取或设置带货达人 OpenTalentId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opentalentid")]
        [System.Text.Json.Serialization.JsonPropertyName("opentalentid")]
        public string? OpenTalentId { get; set; }

        /// <summary>
        /// 获取或设置联盟商品链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_link")]
        [System.Text.Json.Serialization.JsonPropertyName("product_link")]
        public string? ProductLink { get; set; }

        /// <summary>
        /// 获取或设置计划类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_type")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_type")]
        public int? PlanType { get; set; }

        /// <summary>
        /// 获取或设置是否需要在个人橱窗页隐藏。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_hide_for_window")]
        [System.Text.Json.Serialization.JsonPropertyName("is_hide_for_window")]
        public bool? IsHideForWindow { get; set; }
    }
}
