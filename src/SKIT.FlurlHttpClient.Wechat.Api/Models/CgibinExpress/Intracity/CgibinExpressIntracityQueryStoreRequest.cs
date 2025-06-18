namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/querystore 接口的请求。</para>
    /// </summary>
    public class CgibinExpressIntracityQueryStoreRequest : WechatApiRequest, IInferable<CgibinExpressIntracityQueryStoreRequest, CgibinExpressIntracityQueryStoreResponse>
    {
        /// <summary>
        /// 获取或设置商家自定义门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_store_id")]
        public string? OutStoreId { get; set; }

        /// <summary>
        /// 获取或设置微信门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
        public string? StoreId { get; set; }
    }
}
