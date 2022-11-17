namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/window/product/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECWindowProductAddRequest : WechatApiRequest, IInferable<ChannelsECWindowProductAddRequest, ChannelsECWindowProductAddResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置商品来源店铺的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否需要在个人橱窗页隐藏。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_hide_for_window")]
        [System.Text.Json.Serialization.JsonPropertyName("is_hide_for_window")]
        public bool? IsHideForWindow { get; set; }
    }
}
