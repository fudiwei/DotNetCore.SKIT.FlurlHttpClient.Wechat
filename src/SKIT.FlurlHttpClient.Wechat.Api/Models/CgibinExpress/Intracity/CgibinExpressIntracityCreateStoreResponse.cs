namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/createstore 接口的响应。</para>
    /// </summary>
    public class CgibinExpressIntracityCreateStoreResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商家自定义门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_store_id")]
        public string OutStoreId { get; set; } = default!;

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
