namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/service/product/getcardinfo 接口的响应。</para>
    /// </summary>
    public class ChannelsECServiceProductGetCardInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商品 Key。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_key")]
        [System.Text.Json.Serialization.JsonPropertyName("product_key")]
        public string? ProductKey { get; set; }

        /// <summary>
        /// 获取或设置商品卡片 DOM 结构字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DOM")]
        [System.Text.Json.Serialization.JsonPropertyName("DOM")]
        public string? DOMString { get; set; }
    }
}
