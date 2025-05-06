namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/window/getall 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierWindowGetAllRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierWindowGetAllRequest, ChannelsECLeagueHeadSupplierWindowGetAllResponse>
    {
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

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：100</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 100;

        /// <summary>
        /// 获取或设置是否返回总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("need_total_num")]
        public bool? RequireTotalCount { get; set; }

        /// <summary>
        /// 获取或设置是否需要查询达人所有橱窗商品。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_get_all")]
        [System.Text.Json.Serialization.JsonPropertyName("is_get_all")]
        public bool? IsGetAll { get; set; }
    }
}
