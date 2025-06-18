namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/del_store 接口的请求。</para>
    /// </summary>
    public class WxaDeleteStoreRequest : WechatApiRequest, IInferable<WxaDeleteStoreRequest, WxaDeleteStoreResponse>
    {
        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string POIId { get; set; } = string.Empty;
    }
}
