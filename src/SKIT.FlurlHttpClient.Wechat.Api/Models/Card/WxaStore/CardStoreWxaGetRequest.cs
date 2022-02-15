namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/storewxa/get 接口的请求。</para>
    /// </summary>
    public class CardStoreWxaGetRequest : WechatApiRequest, IMapResponse<CardStoreWxaGetRequest, CardStoreWxaGetResponse>
    {
        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string POIId { get; set; } = string.Empty;
    }
}
