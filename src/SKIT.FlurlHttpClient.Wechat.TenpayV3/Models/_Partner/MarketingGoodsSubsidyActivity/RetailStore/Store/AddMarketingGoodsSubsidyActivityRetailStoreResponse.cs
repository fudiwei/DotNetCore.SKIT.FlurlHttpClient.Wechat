using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/goods-subsidy-activity/retail-store-act/{brand_id}/stores 接口的响应。</para>
    /// </summary>
    public class AddMarketingGoodsSubsidyActivityRetailStoreResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Store : QueryMarketingGoodsSubsidyActivityRetailStoresResponse.Types.Store
            {
            }
        }

        /// <summary>
        /// 获取或设置添加失败的门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_stores")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_stores")]
        public Types.Store[]? FailedRepresentativeList { get; set; }

        /// <summary>
        /// 获取或设置添加时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("add_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset AddTime { get; set; }
    }
}
