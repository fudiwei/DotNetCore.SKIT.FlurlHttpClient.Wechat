namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/sharer/get_sharer_live_order_list 接口的请求。</para>
    /// </summary>
    public class ShopSharerGetSharerLiveOrderListRequest : WechatApiRequest, IInferable<ShopSharerGetSharerLiveOrderListRequest, ShopSharerGetSharerLiveOrderListResponse>
    {
        /// <summary>
        /// 获取或设置分享员 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置直播间 ExportId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_export_id")]
        [System.Text.Json.Serialization.JsonPropertyName("live_export_id")]
        public string LiveExportId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分页页数（从 1 开始）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;
    }
}
