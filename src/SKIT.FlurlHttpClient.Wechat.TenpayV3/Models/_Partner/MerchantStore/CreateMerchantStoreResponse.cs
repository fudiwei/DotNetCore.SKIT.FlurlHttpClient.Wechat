namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-store/stores 接口的响应。</para>
    /// </summary>
    public class CreateMerchantStoreResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("store_id")]
        public long StoreId { get; set; }
    }
}
