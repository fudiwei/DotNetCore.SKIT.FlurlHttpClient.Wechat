namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/warehouse/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECWarehouseListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置外部仓库 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_warehouse_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_ids")]
                public string[] OutWarehouseIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置翻页标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_key")]
                [System.Text.Json.Serialization.JsonPropertyName("next_key")]
                public string? NextCursor { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
