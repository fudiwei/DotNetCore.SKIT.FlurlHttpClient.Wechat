namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/storecharge 接口的响应。</para>
    /// </summary>
    public class CgibinExpressIntracityStoreChargeResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置充值页面 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payurl")]
        [System.Text.Json.Serialization.JsonPropertyName("payurl")]
        public string PayUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;
    }
}
