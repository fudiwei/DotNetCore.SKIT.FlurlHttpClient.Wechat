namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/merchant/address/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECMerchantAddressUpdateRequest : WechatApiRequest, IInferable<ChannelsECMerchantAddressUpdateRequest, ChannelsECMerchantAddressUpdateResponse>
    {
        public static class Types
        {
            public class AddressDetail : ChannelsECMerchantAddressAddRequest.Types.AddressDetail
            {
                public static new class Types
                {
                    public class Address : ChannelsECMerchantAddressAddRequest.Types.AddressDetail.Types.Address
                    {
                    }

                    public class AddressType : ChannelsECMerchantAddressAddRequest.Types.AddressDetail.Types.AddressType
                    {
                    }
                }

                /// <summary>
                /// 获取或设置地址 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_id")]
                [System.Text.Json.Serialization.JsonPropertyName("address_id")]
                public long AddressId { get; set; }

                /// <summary>
                /// 获取或设置地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_info")]
                [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                public new Types.Address Address { get; set; } = new Types.Address();

                /// <summary>
                /// 获取或设置地址类型信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_type")]
                [System.Text.Json.Serialization.JsonPropertyName("address_type")]
                public new Types.AddressType? AddressType { get; set; }
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
