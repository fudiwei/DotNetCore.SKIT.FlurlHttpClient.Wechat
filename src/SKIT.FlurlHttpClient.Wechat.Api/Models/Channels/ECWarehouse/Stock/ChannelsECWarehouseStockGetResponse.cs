namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/warehouse/stock/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECWarehouseStockGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置库存数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("num")]
                [System.Text.Json.Serialization.JsonPropertyName("num")]
                public int Stock { get; set; }
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
