using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/warehouse/create 接口的请求。</para>
    /// </summary>
    public class ChannelsECWarehouseCreateRequest : WechatApiRequest, IInferable<ChannelsECWarehouseCreateRequest, ChannelsECWarehouseCreateResponse>
    {
        public static class Types
        {
            public class CoverLocation
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

        /// <summary>
        /// 获取或设置外部仓库 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
        public string OutWarehouseId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置仓库名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置仓库介绍。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intro")]
        [System.Text.Json.Serialization.JsonPropertyName("intro")]
        public string Introduction { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置覆盖区域列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_locations")]
        [System.Text.Json.Serialization.JsonPropertyName("cover_locations")]
        public IList<Types.CoverLocation>? CoverLocationList { get; set; }
    }
}
