namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/warehouse/address/prioritysort/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECWarehouseAddressPrioritySortGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置排序优先级从高到低的外部仓库 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("priority_sort")]
                [System.Text.Json.Serialization.JsonPropertyName("priority_sort")]
                public string[] PrioritySortedOutWarehouseIdList { get; set; } = default!;
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
