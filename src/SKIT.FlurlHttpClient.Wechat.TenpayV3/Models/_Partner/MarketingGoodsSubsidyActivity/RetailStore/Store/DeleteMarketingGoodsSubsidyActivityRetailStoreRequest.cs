namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/stores 接口的请求。</para>
    /// </summary>
    public class DeleteMarketingGoodsSubsidyActivityRetailStoreRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Store : AddMarketingGoodsSubsidyActivityRetailStoreRequest.Types.Store
            {
            }
        }

        /// <summary>
        /// 获取或设置零售小店活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? BrandId { get; set; }

        /// <summary>
        /// 获取或设置请求业务单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string? OutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stores")]
        [System.Text.Json.Serialization.JsonPropertyName("stores")]
        public List<Types.Store>? StoreList { get; set; }

        /// <summary>
        /// 获取或设置删除时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delete_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("delete_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? DeleteTime { get; set; }
    }
}
