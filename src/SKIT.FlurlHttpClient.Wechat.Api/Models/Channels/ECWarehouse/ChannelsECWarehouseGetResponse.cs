namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/warehouse/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECWarehouseGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Warehouse
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
                public string OutWarehouseId { get; set; } = default!;

                /// <summary>
                /// 获取或设置仓库名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置仓库介绍。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intro")]
                [System.Text.Json.Serialization.JsonPropertyName("intro")]
                public string Introduction { get; set; } = default!;

                /// <summary>
                /// 获取或设置覆盖区域列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cover_locations")]
                [System.Text.Json.Serialization.JsonPropertyName("cover_locations")]
                public Types.CoverLocation[]? CoverLocationList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置仓库信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Warehouse Warehouse { get; set; } = default!;
    }
}
