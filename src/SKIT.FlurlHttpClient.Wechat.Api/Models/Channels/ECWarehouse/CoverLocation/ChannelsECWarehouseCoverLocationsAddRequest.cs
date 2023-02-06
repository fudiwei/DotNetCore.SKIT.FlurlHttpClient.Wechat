using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/warehouse/coverlocations/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECWarehouseCoverLocationsAddRequest : WechatApiRequest, IInferable<ChannelsECWarehouseCoverLocationsAddRequest, ChannelsECWarehouseCoverLocationsAddResponse>
    {
        public static class Types
        {
            public class CoverLocation : ChannelsECWarehouseCreateRequest.Types.CoverLocation
            {
            }
        }

        /// <summary>
        /// 获取或设置外部仓库 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
        public string OutWarehouseId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置覆盖区域列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_locations")]
        [System.Text.Json.Serialization.JsonPropertyName("cover_locations")]
        public IList<Types.CoverLocation> CoverLocationList { get; set; } = new List<Types.CoverLocation>();
    }
}
