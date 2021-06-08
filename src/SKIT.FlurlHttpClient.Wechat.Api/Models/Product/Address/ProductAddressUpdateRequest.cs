using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/address/update 接口的请求。</para>
    /// </summary>
    public class ProductAddressUpdateRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Address : ProductAddressAddRequest.Types.Address
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
        /// 获取或设置地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("address_detail")]
        public Types.Address Address { get; set; } = new Types.Address();
    }
}
