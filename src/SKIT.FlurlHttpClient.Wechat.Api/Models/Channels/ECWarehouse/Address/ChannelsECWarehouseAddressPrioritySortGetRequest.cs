namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/warehouse/address/prioritysort/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECWarehouseAddressPrioritySortGetRequest : WechatApiRequest, IInferable<ChannelsECWarehouseAddressPrioritySortGetRequest, ChannelsECWarehouseAddressPrioritySortGetResponse>
    {
        /// <summary>
        /// 获取或设置省份地址编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_id1")]
        [System.Text.Json.Serialization.JsonPropertyName("address_id1")]
        public int ProvinceAddressId { get; set; }

        /// <summary>
        /// 获取或设置市地址编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_id2")]
        [System.Text.Json.Serialization.JsonPropertyName("address_id2")]
        public int? CityAddressId { get; set; }

        /// <summary>
        /// 获取或设置区地址编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_id3")]
        [System.Text.Json.Serialization.JsonPropertyName("address_id3")]
        public int? DistrictAddressId { get; set; }

        /// <summary>
        /// 获取或设置街道地址编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_id4")]
        [System.Text.Json.Serialization.JsonPropertyName("address_id4")]
        public int? StreetAddressId { get; set; }
    }
}
