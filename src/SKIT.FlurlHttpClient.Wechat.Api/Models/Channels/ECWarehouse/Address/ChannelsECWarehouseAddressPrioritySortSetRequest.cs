using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/warehouse/address/prioritysort/set 接口的请求。</para>
    /// </summary>
    public class ChannelsECWarehouseAddressPrioritySortSetRequest : WechatApiRequest, IInferable<ChannelsECWarehouseAddressPrioritySortSetRequest, ChannelsECWarehouseAddressPrioritySortSetResponse>
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

        /// <summary>
        /// 获取或设置排序优先级从高到低的外部仓库 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priority_sort")]
        [System.Text.Json.Serialization.JsonPropertyName("priority_sort")]
        public IList<string> PrioritySortedOutWarehouseIdList { get; set; } = new List<string>();
    }
}
