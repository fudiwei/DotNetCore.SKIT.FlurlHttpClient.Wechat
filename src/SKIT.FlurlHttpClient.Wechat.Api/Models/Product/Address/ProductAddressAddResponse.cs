namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/address/add 接口的响应。</para>
    /// </summary>
    public class ProductAddressAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置地址 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_id")]
        [System.Text.Json.Serialization.JsonPropertyName("address_id")]
        public long AddressId { get; set; }
    }
}
