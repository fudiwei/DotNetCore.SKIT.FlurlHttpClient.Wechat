namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/address/delete 接口的请求。</para>
    /// </summary>
    public class ProductAddressDeleteRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置地址 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_id")]
        [System.Text.Json.Serialization.JsonPropertyName("address_id")]
        public int AddressId { get; set; }
    }
}
