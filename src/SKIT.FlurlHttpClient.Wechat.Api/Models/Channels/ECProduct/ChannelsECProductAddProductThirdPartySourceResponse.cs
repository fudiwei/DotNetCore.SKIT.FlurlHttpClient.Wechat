namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/addproductthirdpartysource 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductAddProductThirdPartySourceResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置第三方货源 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_party_source_id")]
        [System.Text.Json.Serialization.JsonPropertyName("third_party_source_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long ThirdPartySourceId { get; set; }
    }
}
