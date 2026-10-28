namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/stores 接口的响应。</para>
    /// </summary>
    public class DeleteMarketingGoodsSubsidyActivityRetailStoreResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Store : QueryMarketingGoodsSubsidyActivityRetailStoresResponse.Types.Store
            {
            }
        }

        /// <summary>
        /// 获取或设置删除失败的门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_stores")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_stores")]
        public List<Types.Store>? FailedStoreList { get; set; }

        /// <summary>
        /// 获取或设置删除时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delete_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("delete_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset DeleteTime { get; set; }
    }
}
