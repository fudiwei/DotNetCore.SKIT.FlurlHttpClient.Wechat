namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/storecharge 接口的请求。</para>
    /// </summary>
    public class CgibinExpressIntracityStoreChargeRequest : WechatApiRequest, IInferable<CgibinExpressIntracityStoreChargeRequest, CgibinExpressIntracityStoreChargeResponse>
    {
        /// <summary>
        /// 获取或设置微信门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
        public string StoreId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置运力 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_trans_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_trans_id")]
        public string ServiceTransId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置充值金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }
    }
}
