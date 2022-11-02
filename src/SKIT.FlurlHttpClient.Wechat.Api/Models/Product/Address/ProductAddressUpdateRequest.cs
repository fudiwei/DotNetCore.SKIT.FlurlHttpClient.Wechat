namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/address/update 接口的请求。</para>
    /// </summary>
    public class ProductAddressUpdateRequest : WechatApiRequest, IInferable<ProductAddressUpdateRequest, ProductAddressUpdateResponse>
    {
        public static class Types
        {
            public class AddressDetail : ProductAddressAddRequest.Types.AddressDetail
            {
                /// <summary>
                /// 获取或设置地址 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_id")]
                [System.Text.Json.Serialization.JsonPropertyName("address_id")]
                public int AddressId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置地址详细信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("address_detail")]
        public Types.AddressDetail AddressDetail { get; set; } = new Types.AddressDetail();
    }
}
